namespace _2520._Count_the_Digits_That_Divide_a_Number
{
    public class Solution
    {
        public int CountDigits(int num)
        {
            int ans = 0;
            int temp = 1;
            int num2 = num;
            temp = num2 % 10;
            while (temp != 0)
            {
                if (num % temp == 0)
                {
                    ans++;
                }
                num2 = num2 / 10;
                temp = num2 % 10;
            }
            return ans;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.CountDigits(1248));
        }
    }
}
