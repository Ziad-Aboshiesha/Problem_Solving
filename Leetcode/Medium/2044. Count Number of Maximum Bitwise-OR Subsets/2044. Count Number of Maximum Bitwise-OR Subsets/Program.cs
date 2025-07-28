namespace _2044._Count_Number_of_Maximum_Bitwise_OR_Subsets
{
    public class Solution
    {
        public int CountMaxOrSubsets(int[] nums)
        {
            int n = nums.Length;
            int maxOr = 0;
            for (int i = 0; i < n; i++)
            {
                maxOr |= nums[i];
            }
            int count = 0;
            int total = 1 << n;

            for (int mask = 1; mask < total; mask++)
            {
                int currOr = 0;
                for (int i = 0; i < n; i++)
                {
                    if ((mask & (1 << i)) != 0)
                    {
                        currOr |= nums[i];
                    }
                }

                if (currOr == maxOr)
                {
                    count++;
                }
            }

            return count;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
           
        }
    }
}
