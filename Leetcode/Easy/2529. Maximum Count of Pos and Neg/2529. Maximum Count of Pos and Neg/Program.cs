namespace _2529._Maximum_Count_of_Pos_and_Neg
{
    public class Solution
    {
        // time  : O(n)
        // space : O(1)
        public int MaximumCount(int[] nums)
        {
            int pos = 0;
            int neg = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0) pos++;
                else if (nums[i] < 0) neg++;
            }
            return int.Max(pos, neg);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
