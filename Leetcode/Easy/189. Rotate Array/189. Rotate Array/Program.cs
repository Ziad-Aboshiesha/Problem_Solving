namespace _189._Rotate_Array
{

    public class Solution
    {
        // time  : O(n)
        // space : O(n)
        public void Rotate(int[] nums, int k)
        {

            int realTimes = k % nums.Length;

            int[] tempArr = new int[realTimes];
            Array.Copy(nums, nums.Length - realTimes, tempArr, 0, realTimes);

            for (int i = nums.Length - realTimes - 1; i >= 0; i--)
            {
                nums[i + realTimes] = nums[i];
            }

            for (int i = 0; i < realTimes; i++)
            {
                nums[i] = tempArr[i];
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
