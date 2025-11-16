#include<iostream>
#include<vector>
using namespace std;

class Solution {
public:
    int countUnguarded(int m, int n, vector<vector<int>>& guards, vector<vector<int>>& walls) {
        int matrix [m][n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i][j]=0;
            }
        }
        for(int i = 0 ; i < guards.size(); i++)
        {
            matrix[guards[i][0]][guards[i][1]] = 1;
        }
        for(int i = 0 ; i < walls.size(); i++)
        {
            matrix[walls[i][0]][walls[i][1]] = 2;
        }
        int ans = 0 ;
        for (int i = 0; i < m; i++)
        {
            bool is_right = false;
            bool is_left = false;
            int right = n - 1;
            for (int j = 0; j < n && right >-1; j++,right--)
            {
                if(matrix[i][j] == 0 && is_left )
                {
                    ans++;
                    matrix[i][j] = 7;
                }
                else if( matrix[i][j] == 2) 
                {
                    is_left = false;
                }
                else if (matrix[i][j] == 1)
                {
                    is_left = true;
                    
                }
                if(matrix[i][right] == 0 && is_right )
                {
                    ans++;
                    matrix[i][right] = 7;
                }
                else if( matrix[i][right] == 2) 
                {
                    is_right = false;
                }
                else if (matrix[i][right] == 1)
                {
                    is_right = true;
                }
            }
            
        }
        for (int column = 0; column < n; column++)
        {
            bool is_top = false;
            bool is_bottom = false;
            int bottom = m - 1;
            for (int row = 0; row < m && bottom >-1; row++,bottom--)
            {
                if(matrix[row][column] == 0 && is_top )
                {
                    ans++;
                    matrix[row][column] = 7;
                }
                else if( matrix[row][column] == 2) 
                {
                    is_top = false;
                }
                else if (matrix[row][column] == 1)
                {
                    is_top = true;
                }



                if(matrix[bottom][column] == 0 && is_bottom )
                {
                    ans++;
                    matrix[bottom][column] = 7;
                }
                else if( matrix[bottom][column] == 2) 
                {
                    is_bottom = false;
                }
                else if (matrix[bottom][column] == 1)
                {
                    is_bottom = true;
                }
            }
            
        }
        return  m*n - ans - guards.size() - walls.size();
    }
};

int main()
{
    vector<vector<int>> guards = {{0,0}, {1,1}, {2,3}};
    vector<vector<int>> walls  = {{0,1}, {2,2}, {1,4}};
    Solution s ;
    cout<<s.countUnguarded(4,6,guards,walls);
    return 0;
}