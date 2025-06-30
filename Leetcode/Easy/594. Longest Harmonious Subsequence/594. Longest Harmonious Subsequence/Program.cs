namespace _594._Longest_Harmonious_Subsequence
{
    public class Solution
    {
        public int FindLHS(int[] nums)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                keyValuePairs.TryAdd(nums[i], 0);
                keyValuePairs[nums[i]]++;
            }
            int result = 0;
            foreach (var item in keyValuePairs)
            {
                if(keyValuePairs.ContainsKey(item.Key-1))
                {

                    result = Math.Max(result, keyValuePairs[item.Key] + keyValuePairs[item.Key - 1 ]);
                }
                if (keyValuePairs.ContainsKey(item.Key + 1))
                {

                    result = Math.Max(result, keyValuePairs[item.Key] + keyValuePairs[item.Key + 1]);
                }
            }
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
