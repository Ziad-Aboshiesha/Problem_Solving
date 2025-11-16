#include<iostream>
#include<vector>
using namespace std;


class Solution {
public:
    int minNumberOperations(vector<int>& target) {
        int operations = target[0];
        int base = target[0];
        for(int i = 1 ; i < target.size(); i++)
        {
            if( target[i] > base )
            {
                operations+= target[i] - base;
            }
            base = target[i];            
        }
        return operations;
    }
};



int main()
{

    Solution s ;
    vector<int>target = {3,1,1,2};
    cout<< s.minNumberOperations(target);
    return 0;
}