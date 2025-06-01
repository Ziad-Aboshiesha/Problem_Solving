namespace _347._Top_K_Frequent_Elements
{
    public class Solution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int > res = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                res.TryAdd(nums[i], 0);
                res[nums[i]]++;
            }
            return res
           .OrderByDescending(pair => pair.Value)
           .Take(k)
           .Select(pair => pair.Key)
           .ToArray();
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
