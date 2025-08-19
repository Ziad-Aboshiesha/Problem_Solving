namespace _342._Power_of_Four
{
    public class Solution
    {
        public bool IsPowerOfFour(int n)
        {
            if (n <= 0) return false; // powers of 3 must be positive
            double logValue = Math.Log(n, 4);
            return Math.Abs(logValue - Math.Round(logValue)) < 1e-10;
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
