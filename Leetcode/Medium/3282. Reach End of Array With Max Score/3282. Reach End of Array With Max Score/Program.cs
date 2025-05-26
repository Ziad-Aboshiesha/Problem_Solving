namespace _3282._Reach_End_of_Array_With_Max_Score
{

    public class Solution
    {
        public long FindMaximumScore(IList<int> nums)
        {
            long result = 0;
            int temp = nums[0];
            long temp_index = 0;
            for (int i = 1; i < nums.Count() - 1; i++)
            {
                if (nums[i] > temp)
                {
                    result += (i - temp_index) * temp;
                    temp_index = i;
                    temp = nums[i];
                }
            }

            result += (nums.Count() - 1 - temp_index) * temp;
            return result;
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
