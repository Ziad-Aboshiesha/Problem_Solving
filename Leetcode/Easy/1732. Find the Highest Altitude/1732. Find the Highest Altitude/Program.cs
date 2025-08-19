namespace _1732._Find_the_Highest_Altitude
{

    public class Solution
    {
        public int LargestAltitude(int[] gain)
        {
            int current = 0;
            int max = 0;
            for (int i = 0; i < gain.Length; i++)
            {
                current += gain[i];
                max = Math.Max(max, current);
            }


            return max;

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
