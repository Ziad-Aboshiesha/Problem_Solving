namespace _2652._Sum_Multiples
{

    public class Solution
    {
        public int SumOfMultiples(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 || i % 7 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
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
