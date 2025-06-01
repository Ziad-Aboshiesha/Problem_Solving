namespace _2150._Find_All_Lonely_Number
{
    public class Solution
    {
        public IList<int> FindLonely(int[] nums)
        {
            Dictionary<int, int> res = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                res.TryAdd(nums[i], 0);
                res[nums[i]] += 1;
            }
            List<int> result = new List<int>();
            foreach (var item in res)
            {
                if( item.Value >1 || res.ContainsKey(item.Key-1) || res.ContainsKey(item.Key + 1)) continue;
                result.Add(item.Key);
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
