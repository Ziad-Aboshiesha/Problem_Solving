#include<iostream>
#include<vector>
using namespace std;

class Solution {
public:
    int countNegatives(vector<vector<int>>& grid) {
        int rows = grid.size();
        int cols = grid[0].size();
        int count = 0;
        for(int row = 0 ; row < rows; row++)
        {
            for(int col = cols - 1 ; col>=0; col--)
            {
                if(grid[row][col] < 0)
                {
                    count++;
                }else{
                    break;
                }
            }
        }
        return  count;
    }
};
int main()
{
    return 0;
}