namespace _1004._Max_Consecutive_Ones_III
{
    public class Solution
    {
        public int LongestOnes(int[] nums, int k)
        {
            int current = 0;
            int max = 0;
            int left = 0;
            int count_zeros = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                current++;
                if (nums[i] ==0 )
                {
                    count_zeros++;
                }
                if(count_zeros > k)
                {
                    current--;
                    max = Math.Max(max, current);
                    count_zeros--;
                    while (nums[left] !=0 )
                    {
                        current--;
                        left++;
                    }
                    left++;
                    
                }
            }
            max = Math.Max(max, current);
            return max;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Solution s = new Solution();
            Console.WriteLine(s.LongestOnes([0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1], 3));
        }
    }
}
