namespace _643._Maximum_Average_Subarray_I
{
    public class Solution
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            double avg = int.MinValue;
            double max = int.MinValue;
            int count = 0;
            double current = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                current += nums[i];
                count++;
                if(count == k)
                {
                    avg = current / k;
                    max = Math.Max(max, avg);
                    current -=nums[ i - k + 1];
                    count--;

                }
            }


            return max;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Solution s = new Solution();
            Console.WriteLine(s.FindMaxAverage([1, 12, -5, -6, 50, 3], 4));
        }
    }
}
