namespace _64._Minimum_Path_Sum
{
    public class Solution
    {
        public int MinPathSum(int[][] grid)
        {
            
            int m = grid.Length;
            int n = grid[0].Length;
            int[,] dp = new int[m, n];
            dp[m - 1, n - 1] = grid[m - 1][n - 1];
            for (int i = m -1; i >=0;i--)
            {
                for (int j = n -1; j >=0; j--)
                {
                    if(i==m-1 && j==n-1)
                    {
                        continue;
                    }
                    if(i==m-1)
                    {
                        dp[i, j] =grid[i][j] + dp[i, j + 1];
                        continue;
                    }
                    if (j == n - 1)
                    {
                        dp[i, j] = grid[i][j] + dp[i+1, j ];
                        continue;
                    }
                    dp[i, j] = grid[i][j] + Math.Min(dp[i, j + 1], dp[i + 1, j]);
                }
            }
            return dp[0, 0];



            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.MinPathSum([[1, 2, 3], [4, 5, 6]]));
        }
    }
}
