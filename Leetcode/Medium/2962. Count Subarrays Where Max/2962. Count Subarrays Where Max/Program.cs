namespace _2962._Count_Subarrays_Where_Max
{
    public class Solution
    {
        // time  : O(n)
        // space : O(1)
        public long CountSubarrays(int[] nums, int k)
        {
            int max = nums.Max();
            if (nums.Length == 1 && k == 1) return 1;
            if (k == 0 || nums.Length == 0) return 0;
            long count = 0;
            int occurance = 0;
            int right = 0;
            int left = 0;
            for (right = 0; right < nums.Length; right++)
            {
                if (nums[right] == max)
                {
                    occurance++;
                }
                while (occurance >= k)
                {
                    count += nums.Length - right;
                    if (nums[left] == max)
                        occurance--;
                    left++;
                }
            }
            return count;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine( s.CountSubarrays([1, 4, 2, 1],  3));
        }
    }
}
