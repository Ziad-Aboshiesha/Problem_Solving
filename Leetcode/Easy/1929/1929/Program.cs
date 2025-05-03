namespace _1929
{
    public class Solution
    {
        public int[] GetConcatenation(int[] nums)
        {
            int[] arr = new int[2 * nums.Length];
            int n = arr.Length / 2;
            for (int i = 0; i < n; i++)
            {
                arr[i] = nums[i];
                arr[i + n] = nums[i];
            }

            return arr;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
