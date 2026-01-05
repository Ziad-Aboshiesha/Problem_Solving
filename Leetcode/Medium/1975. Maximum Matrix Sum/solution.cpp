#include<iostream>
#include<vector>
using namespace std;

class Solution {
public:
    long long maxMatrixSum(vector<vector<int>>& matrix) {
        long long ans=0;
        int m = matrix.size();
        int neg =0;
        int min = INT_MAX;
        for(int i =0 ; i < m ; i++)
        {
            for(int j=0; j< m; j++)
            {
                ans += abs(matrix[i][j]);

                if(matrix[i][j] < 0)
                {
                    neg++;
                }
                if( abs(matrix[i][j]) < min)
                {
                    min = abs(matrix[i][j]);
                }
            }
        }
        if(neg % 2 ==0)
        {
            return ans;
        }
        else
        {
            return ans - 2 * min;
        }
    
    }
};
//time : n * n
//space : 1
int main()
{
    return 0;
}