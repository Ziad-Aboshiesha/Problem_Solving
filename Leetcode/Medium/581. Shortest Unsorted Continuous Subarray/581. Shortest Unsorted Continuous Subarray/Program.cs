namespace _581._Shortest_Unsorted_Continuous_Subarray
{
    public class Solution
    {

        // time  : O(n * log(n))
        // space : O(n)
        public int FindUnsortedSubarray(int[] nums)
        {
            int answer = 0;

            int[] n = new int[nums.Length];
            Array.Copy(nums, n, nums.Length);
            Array.Sort(n);
            int start = 0;
            int end = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != n[i])
                {
                    end = i;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != n[i])
                {
                    start = i;
                    break;
                }
            }

            return end - start == 0 ? 0 : end - start + 1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
