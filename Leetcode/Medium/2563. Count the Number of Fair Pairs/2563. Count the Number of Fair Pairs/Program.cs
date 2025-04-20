namespace _2563._Count_the_Number_of_Fair_Pairs
{
    public class Solution
    {
        // time  : O(n log n)
        // space : O(1)
        public long CountFairPairs(int[] nums, int lower, int upper)
        {
            long count = 0;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int first = i + 1;
                int end = nums.Length - 1;
                int mid=0, mid2=0;
                int answer1 = 0;
                int answer2 = 0;
                while(first <=end)
                {
                    mid = (first + end) / 2;
                    if (nums[i] + nums[mid] >= lower)
                    {
                        end = mid - 1;
                        answer1 =mid;
                    }
                    else
                    {
                        first = mid + 1;
                    }
                }

                first = i + 1;
                end = nums.Length - 1;

                while (first <= end)
                {
                    mid2 = (first + end) / 2;
                    if (nums[i] + nums[mid2] <= upper)
                    {
                        first = mid2 + 1;
                        answer2 =mid2;
                    }
                    else
                    {
                        end = mid2 - 1;
                    }
                }
                if(answer1 != 0 && answer2 != 0 )
                count += answer2 - answer1 + 1;
            }

            return count;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine( s.CountFairPairs([0, 1, 7, 4, 4, 5],3,6));
        }
    }
}
