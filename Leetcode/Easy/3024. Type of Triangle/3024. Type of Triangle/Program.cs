namespace _3024._Type_of_Triangle
{
    public class Solution
    {
        // time  : O(1)
        // space : O(1)
        public string TriangleType(int[] nums)
        {

            if (nums[0] + nums[1] > nums[2] && nums[1] + nums[2] > nums[0] && nums[2] + nums[0] > nums[1])
            {
                if (nums[0] == nums[1] && nums[1] == nums[2])
                {
                    return "equilateral";
                }
                if (nums[0] == nums[1] || nums[0] == nums[2] || nums[1] == nums[2])
                {
                    return "isosceles";
                }
                return "scalene";
            }
            else
            {
                return "none";
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
