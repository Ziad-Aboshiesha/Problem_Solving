namespace _62._Unique_Paths
{
    public class Solution
    {
        // time  : O( n * m )
        // space : O( n * m )
        public int UniquePaths(int m, int n)
        {
            if (m == 1 && n == 1)
                return 1;
            int[,] dp = new int[m, n];
            dp[m - 1, n - 1] = 0;
            for (int i = m - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {

                    if (!(i == m - 1 && j == n - 1))  // ignore most down right bit
                    {
                        if (i == m - 1)             // if no down take right only
                        {
                            dp[i, j] = 1;
                            continue;
                        }
                        if (j == n - 1)               //if no right take down only 
                        {
                            dp[i, j] = 1;
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
            Console.WriteLine(s.UniquePaths(1, 1));
        }
    }
}
