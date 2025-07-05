namespace _1394._Find_Lucky_Integer_in_an_Array
{
    public class Solution
    {
        public int FindLucky(int[] arr)
        {
           Dictionary<int, int > keyValuePairs = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                keyValuePairs.TryAdd(arr[i], 0);
                keyValuePairs[arr[i]]++;

            }
            int ans = -1;
            foreach (var item in keyValuePairs)
            {
                if (item.Key == item.Value)
                    ans = Math.Max(ans, item.Value);
            }
            return ans;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
