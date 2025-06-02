namespace _2413._Smallest_Even_Multiple
{
    public class Solution
    {
        public int SmallestEvenMultiple(int n)
        {
            if (n % 2 == 0) return n;
            return n * 2;
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
