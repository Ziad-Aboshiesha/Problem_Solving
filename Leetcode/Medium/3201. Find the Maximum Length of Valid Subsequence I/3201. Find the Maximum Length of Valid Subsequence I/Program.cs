namespace _3201._Find_the_Maximum_Length_of_Valid_Subsequence_I
{
    public class Solution
    {
        public int MaximumLength(int[] nums)
        {
            int count_even = 0;
            int count_odd  = 0;
            int count_mix  = 0;
            bool status = nums[0] % 2 == 0 ;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0) count_even++;
                else count_odd++;

                if (status == true && nums[i] % 2 != 0 && i != 0)
                {
                    count_mix++;
                    status = false;
                }
                else if (status == false && nums[i] %2 == 0 && i != 0)
                {    
                    count_mix++;
                    status = true;
                }

            }
            return Math.Max(count_even, Math.Max(count_odd,count_mix+1));
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
