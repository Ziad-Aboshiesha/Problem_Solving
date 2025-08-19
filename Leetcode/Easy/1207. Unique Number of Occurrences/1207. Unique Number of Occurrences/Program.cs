namespace _1207._Unique_Number_of_Occurrences
{
    public class Solution
    {
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int,int> nums = new Dictionary<int,int>();
            for (int i = 0; i < arr.Length; i++)
            {
                nums.TryAdd(arr[i],0);
                nums[arr[i]]++;
            }
            HashSet<int> visited = new HashSet<int>();
            foreach (int i in nums.Values)
            {
                if(visited.Contains(i))
                {
                    return false;
                }
                visited.Add(i);
            }
            return true;
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
