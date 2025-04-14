namespace _217._Contains_Duplicate
{
    public class Solution
    {
        // time  : O(n * log(n))
        // space : O(1)
        public bool ContainsDuplicate(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    return true;
                }
            }
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
