using System.Collections;

namespace _1338._Reduce_Array_Size_to_The_Half
{
    public class Solution
    {
        public int MinSetSize(int[] arr)
        {
            Dictionary<int, int> dct = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!dct.ContainsKey(arr[i]))
                {
                    dct.Add(arr[i], 0);
                }
                dct[arr[i]]++;
            }
            List<KeyValuePair<int, int>> sortedList = dct.OrderByDescending(pair => pair.Value).ToList();
            int deleted = 0;
            int size = 0;
            for (int i = 0; i < sortedList.Count; i++)
            {
                if (size >= arr.Length / 2)
                {
                    break;
                }
                else
                {
                    deleted++;
                    size += sortedList[i].Value;
                }
            }
            return deleted;

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
