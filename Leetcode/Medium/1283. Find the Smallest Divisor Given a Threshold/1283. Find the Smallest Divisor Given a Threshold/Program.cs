namespace _1283._Find_the_Smallest_Divisor_Given_a_Threshold
{

    public class Solution
    {
        // time  : O(n log m)
        // space : O(1)
        public int SmallestDivisor(int[] nums, int threshold)
        {
            int answer = 0;
            Array.Sort(nums);
            int end = nums[nums.Length -1 ];
            int start = 0;
            while (start <= end) 
            {
                int mid = (start + end) / 2;

                double temp = 0;
                for (global::System.Int32 i = nums.Length -1 ; i >=0; i--)
                {
                    double division = (double)nums[i] / mid;
                    temp += Math.Ceiling(division);
                    if(temp > threshold)
                    {
                        break;
                    }
                }
                if(temp > threshold)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                    answer = mid;
                }
            }
            return answer;
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.SmallestDivisor([5,9,2, 1], 6));
        }
    }
}
