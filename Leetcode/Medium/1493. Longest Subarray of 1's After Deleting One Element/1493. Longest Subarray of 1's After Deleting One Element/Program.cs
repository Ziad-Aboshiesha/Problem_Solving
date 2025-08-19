namespace _1493._Longest_Subarray_of_1_s_After_Deleting_One_Element
{
    public class Solution
    {
        public int LongestSubarray(int[] nums)
        {
            int k = 1;
            int current = 0;
            int max = 0;
            int left = 0;
            int count_zeros = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                current++;
                if (nums[i] == 0)
                {
                    count_zeros++;
                }
                if (count_zeros > k)
                {
                    current--;
                    max = Math.Max(max, current);
                    count_zeros--;
                    while (nums[left] != 0)
                    {
                        current--;
                        left++;
                    }
                    left++;

                }
            }
            max = Math.Max(max, current);
            return max - 1;
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
