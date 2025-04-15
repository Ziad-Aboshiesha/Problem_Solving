namespace _34._Find_First_and_Last_Position_of_Element_in_Sorted
{
    public class Solution
    {
        //* time : o(log n)
        //* space : o(1)
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0) return new int[2] { -1, -1 };
            if (nums.Length == 1 && nums[0] == target) return new int[2] { 0, 0 };

            int start = 0;
            int end = nums.Length - 1;
            int first = -1;
            int last = -1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (nums[mid] == target)
                {
                    first = mid;
                    break;
                }
                if (nums[mid] < target)
                {
                    start = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    end = mid - 1;
                }
            }
            if (first == -1) return new int[2] { -1, -1 };
            int temp1 = first;
            last = first;
            if (temp1 - 1 >= 0 && nums[temp1] == nums[temp1 - 1])
            {
                while (temp1 - 1 >= 0 && nums[temp1 - 1] == nums[first])
                {
                    temp1--;
                }

            }
            int temp2 = first;
            if (temp2 + 1 < nums.Length && nums[temp2] == nums[temp2 + 1])
            {
                while (temp2 + 1 < nums.Length && nums[temp2 + 1] == nums[first])
                {
                    temp2++;
                }
            }
            return new int[2] { temp1, temp2 };
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
