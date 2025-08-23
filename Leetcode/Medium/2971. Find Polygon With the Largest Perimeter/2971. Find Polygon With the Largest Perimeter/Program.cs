namespace _2971._Find_Polygon_With_the_Largest_Perimeter
{
    internal class Program
    {
        public class Solution
        {
            public long LargestPerimeter(int[] nums)
            {
                Array.Sort(nums);
                long result = -1;
                long perimeter = nums[0] + nums[1];
                for (int i = 2; i < nums.Length; i++)
                {
                    perimeter += nums[i];
                    if (perimeter - nums[i] > nums[i])
                    {
                        result = perimeter;
                    }
                        

                }
                return result;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
