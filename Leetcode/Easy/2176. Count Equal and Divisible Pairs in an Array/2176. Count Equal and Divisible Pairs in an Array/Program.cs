namespace _2176._Count_Equal_and_Divisible_Pairs_in_an_Array
{

    public class Solution
    {

        // time  : O(n*n)
        // space : O(1)


        public int CountPairs(int[] nums, int k)
        {
            if (nums == null || k == 0 || nums.Length ==1) return 0;
            
            int count = 0;
            for (int i = 0; i < nums.Length -  1; i++)
            {
                for (global::System.Int32 j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i * j % k == 0 )
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine( s.CountPairs([3,1,2,2,2,1,3], 2));
        }
    }
}
