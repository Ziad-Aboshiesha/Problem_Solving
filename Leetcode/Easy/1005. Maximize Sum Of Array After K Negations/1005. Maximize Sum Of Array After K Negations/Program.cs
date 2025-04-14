namespace _1005._Maximize_Sum_Of_Array_After_K_Negations
{

    public class Solution
    {
        // time  : O(k * n * log(n))
        // space : O(1)
        public int LargestSumAfterKNegations(int[] nums, int k)
        {
            Array.Sort(nums);
            for (int i = 0; i < k; i++)
            {

                nums[0] = -nums[0];

                Array.Sort(nums);

            }


            return nums.Sum();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
