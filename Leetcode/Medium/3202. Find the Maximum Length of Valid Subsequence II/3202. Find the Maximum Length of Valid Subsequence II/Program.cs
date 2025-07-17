namespace _3202._Find_the_Maximum_Length_of_Valid_Subsequence_II
{
    public class Solution
    {
        public int MaximumLength(int[] nums, int k)
        {
            int res = 0;
            int[,] dp = new int[k, k];

            for (int i = 0; i < nums.Length; i++)
            {
                int rem = nums[i] % k;
                for (int j = 0; j < k; j++)
                {
                    // You likely intended to update [j, rem]
                    dp[j, rem] = dp[rem, j] + 1;

                    // Update result
                    res = Math.Max(res, dp[j, rem]);
                }
            }

            return res;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
