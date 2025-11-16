#include<iostream>
#include<vector>
using namespace std;
class Solution {
public:
    vector<vector<int>> rangeAddQueries(int n, vector<vector<int>>& queries) {
        vector<vector<int>> ans (n,vector<int>(n));
        for(int i = 0 ;i<n; i++)
        {
            for(int j = 0 ; j<n ; j++)
            {
                ans[i][j]=0;
            }
            
        }
        for(int i = 0 ; i <queries.size();i++)
        {
            
            for(int j = queries[i][0]; j <= queries[i][2]; j++ )
            {
                for(int k = queries[i][1]; k<=queries[i][3] ;k++)
                {
                    ans[j][k]++;
                }
            }

        }
        return ans;
    }
};
int main()
{


    return 0;
}