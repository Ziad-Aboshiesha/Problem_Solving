namespace _2401._Longest_Nice_Subarray
{
    public class Solution
    {
        // time  : O()
        // space : O(1)
        public int LongestNiceSubarray(int[] nums)
        {
            int total_count = 1;
            bool flag = false;
            for (int i = 0; i < nums.Length; i++)
            {
                flag = false;
                int inner_count = 1;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (((nums[i] & nums[j]) == 0) && (nums[j] % 2 == 0 || nums[j - 1] % 2 == 0))
                    {
                        inner_count++;
                    }
                    else
                    {
                        if (inner_count == 1) break;
                        else
                        {
                            for (int k = i + 1; k <= j; k++)
                            {
                                for (int l = k + 1; l < j; l++)
                                {
                                    if (((nums[k] & nums[l]) != 0))
                                    {
                                        flag = true;
                                        inner_count = l - i;
                                        total_count = int.Max(total_count, inner_count);
                                        break;
                                    }
                                }
                                if (flag == true) break;
                            }
                            if (flag == false)
                            {
                                total_count = int.Max(total_count, inner_count);
                                inner_count = 1;
                            }
                        }
                    }
                    if (flag == true) break;
                }
                total_count = int.Max(total_count, inner_count);
            }
            return total_count;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
