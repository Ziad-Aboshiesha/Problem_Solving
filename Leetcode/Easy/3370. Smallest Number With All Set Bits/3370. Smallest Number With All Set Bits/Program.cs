namespace _3370._Smallest_Number_With_All_Set_Bits
{
    internal class Program
    {
        public class Solution
        {
            public int SmallestNumber(int n)
            {
                if (n == 1) return 1;
                double x = Math.Log(n, 2) + 1 ;
                return (int)Math.Pow(2, (int)Math.Floor(x)) - 1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
