namespace _2348._Number_of_Zero_Filled_Subarrays
{
    internal class Program
    {
        public class Solution
        {
            public long ZeroFilledSubarray(int[] nums)
            {
                long ans = 0;
                long count = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 0) 
                    {
                        count++;
                    }
                    else
                    {
                        if( count != 0 )
                        {
                            ans += (count * (count + 1)) / 2;
                            count = 0;
                        }
                    }
                }
                if (count != 0)
                {
                    ans += (count * (count + 1)) / 2;
                }
                return ans;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
