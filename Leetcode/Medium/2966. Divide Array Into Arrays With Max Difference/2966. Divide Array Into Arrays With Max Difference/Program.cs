namespace _2966._Divide_Array_Into_Arrays_With_Max_Difference
{
    public class Solution
    {
        // time  : O(n log n)
        // space : O(n)
        public int[][] DivideArray(int[] nums, int k)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2 ; i += 3)
            {
                if (nums[i +2] - nums[i] <= k )
                {
                    continue;
                }
                else
                {
                    return [];
                }
            }
            int groupCount = nums.Length / 3;
            int[][] result = new int[groupCount][];

            for (int i = 0; i < groupCount; i++)
            {
                result[i] = new int[3];
                Array.Copy(nums, i * 3, result[i], 0, 3);
            }

            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
