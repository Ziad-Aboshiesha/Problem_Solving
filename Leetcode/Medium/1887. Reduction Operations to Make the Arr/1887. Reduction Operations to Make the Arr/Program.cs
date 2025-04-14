namespace _1887._Reduction_Operations_to_Make_the_Arr
{
    public class Solution
    {
        // time  : O(n * log(n))
        // space : O(1)
        public int ReductionOperations(int[] nums)
        {
            int steps = 0;
            Array.Sort(nums);
            int temp = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] == nums[i])
                {
                    steps += temp;
                    continue;
                }
                temp++;
                steps += temp;

            }

            return steps;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
