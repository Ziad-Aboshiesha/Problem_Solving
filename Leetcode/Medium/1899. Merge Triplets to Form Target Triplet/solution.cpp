#include<iostream>
#include<vector>
using namespace std;

class Solution {
public:
    bool mergeTriplets(vector<vector<int>>& triplets, vector<int>& target) {
        int first=0, second=0, third = 0;
        for(int i = 0 ; i < triplets.size();i++)
        {
            if(triplets[i][0]==target[0] && triplets[i][1]<=target[1] && triplets[i][2]<=target[2])
            {
                first = 1;
            }
            if(triplets[i][1]==target[1] && triplets[i][0]<=target[0] && triplets[i][2]<=target[2])
            {
                second = 1;
            }
            if(triplets[i][2]==target[2] && triplets[i][1]<=target[1] && triplets[i][0]<=target[0])
            {
                third = 1;
            }
        }
        if(first ==1 && second==1 && third==1)
        {
            return true;
        }return false;
    }
};

int main()
{
    return 0;
}