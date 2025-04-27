namespace _3392._Count_Subarrays_of_Length
{
    public class Solution
    {
        // time  : O(n)
        // space : O(1)
        public int CountSubarrays(int[] nums)
        {
            int count = 0;
            
            for (int i = 0; i < nums.Length - 2; i++)
            {
                int j = i + 2;
                if (nums[i] + nums[j] == nums[i+1]/2.0)
                {
                    count++;
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
            Console.WriteLine(s.CountSubarrays([1, 2, 1, 4, 1]));
        }
    }
}
