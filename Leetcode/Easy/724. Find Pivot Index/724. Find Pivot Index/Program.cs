namespace _724._Find_Pivot_Index
{
    public class Solution
    {
        public int PivotIndex(int[] nums)
        {
            int[] left = new int[nums.Length];
            int[] right = new int[nums.Length];
            int sum_left = 0;
            int sum_right = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum_left += nums[i];
                sum_right += nums[nums.Length -1 - i];
                left[i] = sum_left;
                right[i] = sum_right;
            }
            int ans = -1;
            for (int i = 0; i < left.Length; i++)
            {
                if (left[i] == right[right.Length - i -1])
                {
                    ans = i;
                    break;
                }
            }
            return ans;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.PivotIndex([1, 7, 3, 6, 5, 6]));
        }
    }
}
