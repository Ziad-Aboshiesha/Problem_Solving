namespace _1920._Build_Array_from_Permutation
{
    public class Solution
    {
        // time  : O(n)
        // space : O(n)
        public int[] BuildArray(int[] nums)
        {
            int[] arr = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                arr[i] = nums[nums[i]];
            }
            return arr;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
