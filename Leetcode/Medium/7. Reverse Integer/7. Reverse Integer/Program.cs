namespace _7._Reverse_Integer
{
    public class Solution
    {
        public int Reverse(int x)
        {
            int result = 0;
            while (x != 0)
            {
                int digit = x % 10;

                // Check if result * 10 + digit will overflow
                if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > 7))
                    return 0;
                if (result < int.MinValue / 10 || (result == int.MinValue / 10 && digit < -8))
                    return 0;

                result = result * 10 + digit;
                x /= 10;
            }
            return result;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.Reverse(1534236469));
        }
    }
}
