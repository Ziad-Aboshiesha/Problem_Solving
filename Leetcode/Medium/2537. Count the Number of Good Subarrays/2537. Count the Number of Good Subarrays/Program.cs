using System.Collections;

namespace _2537._Count_the_Number_of_Good_Subarrays
{
    public class Solution
    {
        // time  : O(n)
        // space : O(1)
        public long CountGood(int[] nums, int k)
        {
            if(nums.Length<=1) return 0;
            int count = 0;

            int right = 0;
            int left = 0;
            int pairs = 0;
            Dictionary<int,int> freq = new Dictionary<int,int>();

            for (left = 0;  left< nums.Length; left++)
            {
                if (!freq.ContainsKey(nums[left]))
                {
                    freq[nums[left]] = 0;
                }
                freq[nums[left]]++;
                pairs += freq[nums[left]] - 1;

                while(pairs >= k)
                {
                    count +=nums.Length - left ;
                    freq[nums[right]]--;
                    pairs -= freq[nums[right]];
                    right++;
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
            Console.WriteLine(   s.CountGood([3, 1, 4, 3, 2, 2, 4], 2));
        }
    }
}
