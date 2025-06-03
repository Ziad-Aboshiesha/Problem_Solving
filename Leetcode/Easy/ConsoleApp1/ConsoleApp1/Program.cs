namespace ConsoleApp1
{
    public class Solution
    {
        public int FindGCD(int[] nums)
        {
            int mn = int.MaxValue;
            int mx = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > mx) mx = nums[i];
                if (nums[i] < mn) mn = nums[i];

            }
            return CalcGCD(mx, mn);

        }
        private int CalcGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
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
