namespace _2770._Maximum_Number_of_Jumps_to_Reach_the_Last
{
   
        public class Solution
        {
            public int MaximumJumps(int[] nums, int target)
            {
                int[] dp = new int[nums.Length];
                dp[0] = 1;
                for (int i = 1; i < nums.Length; i++)
                {
                    int max = 0;
                    for (int j = 0; j < i; j++)
                    {
                        if (Math.Abs(nums[j] - nums[i]) <= target&& dp[j]!=0 && dp[j] + 1 > dp[i])
                        {
                            dp[i] = dp[j] + 1;
                        }
                    }
                }
            if (dp[nums.Length - 1] == 0) return -1;
                return dp[nums.Length - 1] -1;
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Solution s = new Solution();
                Console.WriteLine(s.MaximumJumps([1, 3, 6, 4, 1, 2], 2));
            }
        }
}

