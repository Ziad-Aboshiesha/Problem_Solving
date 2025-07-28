namespace _1470._Shuffle_the_Array
{
    public class Solution
    {
        public int[] Shuffle(int[] nums, int n)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < n; i+=1) 
            {
                result.Add(nums[i]);
                result.Add(nums[i+n]);
            }
            return result.ToArray();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] nums = s.Shuffle([2, 5, 1, 3, 4, 7], 3);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
