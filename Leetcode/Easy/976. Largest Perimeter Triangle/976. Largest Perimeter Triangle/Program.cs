namespace _976._Largest_Perimeter_Triangle
{
    public class Solution
    {
        // time  : O(n * log(n))
        // space : O(1)
        public int LargestPerimeter(int[] nums)
        {
            Array.Sort(nums);
            int max = 0;
            for (int i = nums.Length - 1; i > 1; i--)
            {
                if (max < nums[i] + nums[i - 1] + nums[i - 2] && nums[i] < nums[i - 1] + nums[i - 2])
                {
                    return nums[i] + nums[i - 1] + nums[i - 2];
                }
            }
            return 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
