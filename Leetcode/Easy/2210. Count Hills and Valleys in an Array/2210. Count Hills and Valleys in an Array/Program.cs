
namespace _2210._Count_Hills_and_Valleys_in_an_Array
{
    public class Solution
    {
        public int CountHillValley(int[] nums)
        {
            List<int> numbers = new List<int>();
            numbers.Add(nums[0]);
            for (int i = 1; i < nums.Length ; i++)
            {
                if(nums[i] != nums[i-1])
                {
                    numbers.Add(nums[i]);
                }
            }
            int ans = 0;
            for (int i = 1; i < numbers.Count - 1; i++)
            {
                if ((numbers[i] > numbers[i-1] && numbers[i] > numbers[i+1]) || 
                    (numbers[i] < numbers[i - 1] && numbers[i] < numbers[i + 1]))
                {
                    ans++;
                }
            }
            return ans;
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
