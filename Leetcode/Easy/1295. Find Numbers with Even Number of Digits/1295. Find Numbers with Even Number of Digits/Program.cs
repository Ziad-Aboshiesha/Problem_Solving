namespace _1295._Find_Numbers_with_Even_Number_of_Digits
{
    public class Solution
    {
        // time  : O(n * m) can be optimized in o(n) using log 10 
        // space : O(1)
        public int FindNumbers(int[] nums)
        {
            int count_even = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                int count_digits = 0;
                while (num != 0)
                {
                    num = num / 10;
                    count_digits++;
                }
                if (count_digits % 2 == 0)
                {
                    count_even++;
                }
            }
            return count_even;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.FindNumbers([12, 345, 2, 6, 7896]));
        }
    }
}
