namespace _63._Unique_Paths_II
{

    public class Solution
    {
        // time  : O(n * m)
        // space : O(n * m)
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int m = obstacleGrid.Length;
            int n = obstacleGrid[0].Length;
            if (obstacleGrid[m - 1][n - 1] == 1)
                return 0;
            if (m == 1 && n == 1)
                return 1;

            int[,] dp = new int[m, n];
            dp[m - 1, n - 1] = 1;
            for (int i = m - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {

                    if (!(i == m - 1 && j == n - 1))  // ignore most down right bit
                    {
                        if (obstacleGrid[i][j] == 1)
                        {
                            dp[i, j] = 0;
                            continue;
                        }
                        if (i == m - 1)             // if no down take right only
                        {
                            
                            dp[i, j] = dp[i,j+1];
                            continue;
                        }
                        if (j == n - 1)               //if no right take down only 
                        {
                            
                            dp[i, j] = dp[i+1,j];
                            continue;
                        }
                        dp[i, j] = dp[i, j + 1] + dp[i + 1, j];
                    }
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
            Console.WriteLine(s.UniquePathsWithObstacles([[0, 1, 0, 0]]));
        }
    }
}
