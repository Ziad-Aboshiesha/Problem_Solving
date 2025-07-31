namespace _898._Bitwise_ORs_of_Subarrays
{
    public class Solution
    {
        public int SubarrayBitwiseORs(int[] arr)
        {
            HashSet<int> ans = new HashSet<int>();
            HashSet<int> current = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++) 
            {
                ans.Add(arr[i]);
                HashSet<int> curr2 = new HashSet<int>();
                foreach (var item in current)
                {
                    curr2.Add(item | arr[i]);
                }
                current = curr2;
                current.Add(arr[i]);

                foreach (var item in current)
                {
                    ans.Add(item);
                }
            }


            return ans.Count;
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
