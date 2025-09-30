namespace _3516._Find_Closest_Person
{
    internal class Program
    {
        public class Solution
        {
            public int FindClosest(int x, int y, int z)
            {
                if (Math.Abs(z - x) < Math.Abs(z - y))
                {
                    return 1;
                }
                else if (Math.Abs(z - x) > Math.Abs(z - y))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
