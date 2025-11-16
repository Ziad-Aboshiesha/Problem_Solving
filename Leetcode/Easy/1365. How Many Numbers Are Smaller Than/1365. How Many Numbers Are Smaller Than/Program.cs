namespace _1365._How_Many_Numbers_Are_Smaller_Than
{

    public class Solution
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] counts = new int[101];
            int max = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                counts[nums[i]]++;
                max = Math.Max(max, nums[i]);
            }
            int sum = 0;
            
            for(int i = 0; i <= max; i++)
            {
                if (counts[i]!= 0 )
                {
                    int temp = counts[i];
                    counts[i] = sum;
                    sum += temp;
                }
                else
                {
                    continue;
                }
            }
            int[]ans = new int[nums.Length];
            for (int i = 0; i < ans.Length; i++)
            {
                ans[i] = counts[nums[i]];
            }
            return ans;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.SmallerNumbersThanCurrent([6, 5, 4, 8]);
        }
    }
}
