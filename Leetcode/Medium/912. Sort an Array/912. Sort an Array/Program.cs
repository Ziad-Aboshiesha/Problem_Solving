namespace _912._Sort_an_Array
{
    public class Solution
    {
        // time  : O(m+n) m → max , k → average occurance
        // space : O(m) m  → max value
        public int[] SortArray(int[] nums)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (Math.Abs(nums[i]) > max)
                {
                    max = Math.Abs(nums[i]);
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            int[] helper_arr = new int[2 * max + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                helper_arr[nums[i] + Math.Abs(max)] += 1;
            }
            int idx = 0;
            for (int i = 0; i < helper_arr.Length; i++)
            {
                if (helper_arr[i] == 0) continue;
                for (global::System.Int32 j = 0; j < helper_arr[i]; j++)
                {
                    nums[idx] = i - max;
                    idx++;
                }
            }
            return nums;
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
