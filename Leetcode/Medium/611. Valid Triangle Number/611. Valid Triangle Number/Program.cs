namespace _611._Valid_Triangle_Number
{
    public class Solution
    {
        // * time : o(n* n*logn)
        // * space : o(1)
        public int TriangleNumber(int[] nums)
        {
            Array.Sort(nums);
            int count = 0;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (global::System.Int32 j = i + 1; j < nums.Length - 1; j++)
                {
                    int start = j + 1;
                    int end = nums.Length - 1;
                    int mid = (start + end) / 2;

                    while (start <= end)
                    {
                        mid = (start + end) / 2;

                        if (nums[i] + nums[j] > nums[mid])
                        {
                            start = mid + 1;
                        }
                        else
                        {
                            end = mid - 1;
                        }
                    }

                    count += mid - j - 1;
                    if (nums[i] + nums[j] > nums[mid]) count++;
                }
            }
            return count;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
