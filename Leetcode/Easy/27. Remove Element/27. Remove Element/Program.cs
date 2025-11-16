namespace _27._Remove_Element
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {

            int count = 0;
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                if (nums[left] == val && nums[right] != val)
                {
                    int temp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = temp;
                    left++;
                    right--;
                    continue;
                }
                if (nums[left] != val)
                {
                    left++;
                }
                if (nums[right] == val)
                {
                    right--;
                }


            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    count++;
                }
            }
            return nums.Length - count;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.RemoveElement([0, 1, 2, 2, 3, 0, 4, 2], 2));
        }
    }
}
