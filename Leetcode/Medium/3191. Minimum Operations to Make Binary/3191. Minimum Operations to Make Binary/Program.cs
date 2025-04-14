namespace _3191._Minimum_Operations_to_Make_Binary
{
    public class Solution
    {
        // time  : O(n)
        // space : O(1)
        public int MinOperations(int[] nums)
        {
            int count = 0;
            if (!nums.Contains(0))
            {
                return 0;
            }
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] == 1)
                    continue;
                else
                {
                    count++;
                    nums[i] = nums[i] ^ 1;
                    nums[i + 1] = nums[i + 1] ^ 1;
                    nums[i + 2] = nums[i + 2] ^ 1;

                }
            }
            if (!nums.Contains(0))
            {
                return count;
            }
            else
            {
                return -1;
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
