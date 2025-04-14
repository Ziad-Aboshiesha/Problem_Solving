namespace _416._Partition_Equal_Subset_Sum
{
    public class Solution
    {
        // time  : O(n * target)
        // space : O(targert)
        public bool CanPartition(int[] nums)
        {

            int total_sum = nums.Sum();
            if (total_sum % 2 == 1)
                return false;

            int target = total_sum / 2;
            bool[] dp = new bool[target + 1];
            dp[0] = true;
            foreach (var item in nums)
            {
                for (global::System.Int32 i = target; i >= item; i--)
                {
                    dp[i] = dp[i] || dp[i - item];
                }
            }
            return dp[target];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
