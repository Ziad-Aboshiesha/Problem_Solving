#include<iostream>
#include<vector>
using namespace std;


//-----------------------------------------------------------
//--------------------------O(m*n)---------------------------------


// class Solution {
// public:
//     int countNegatives(vector<vector<int>>& grid) {
//         int rows = grid.size();
//         int cols = grid[0].size();
//         int count = 0;
//         for(int row = 0 ; row < rows; row++)
//         {
//             for(int col = cols - 1 ; col>=0; col--)
//             {
//                 if(grid[row][col] < 0)
//                 {
//                     count++;
//                 }else{
//                     break;
//                 }
//             }
//         }
//         return  count;
//     }
// };
//-----------------------------------------------------------
// 
//--------------------------O(m+n)---------------------------------
// class Solution {
// public:
//     int countNegatives(vector<vector<int>>& grid) {
//         int m = grid.size();
//         int n = grid[0].size();

//         int row = m - 1;
//         int col = 0;
//         int count = 0;

//         while (row >= 0 && col < n) {
//             if (grid[row][col] < 0) {
//                 count += (n - col);
//                 row--;
//             } else {
//                 col++;
//             }
//         }

//         return count;
//     }
// };

int main()
{
    return 0;
}