namespace _771._Jewels_and_Stones
{

    public class Solution
    {
        // time  : O(n*m)
        // space : O(1)
        public int NumJewelsInStones(string jewels, string stones)
        {

            int count = 0;
            foreach (char stone in stones)
            {
                if (jewels.Contains(stone))
                {
                    count++;
                }
            }
            return count;
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
