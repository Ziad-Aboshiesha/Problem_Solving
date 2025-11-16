#include<iostream>
#include<vector>
using namespace std;
class Solution {
public:
    int findJudge(int n, vector<vector<int>>& trust) {
        vector<int> sum(n+1, 0);
        for(int i = 0 ;i < trust.size();i++)
        {
            sum[trust[i][0]]--;
            sum[trust[i][1]]++;
        }
        for(int i = 1 ; i< sum.size(); i ++)
        {
            if(sum[i]== n-1) return i;
        }
        return -1;

    }
};
int main()
{
    return 0;
}