namespace _1518._Water_Bottles
{

    public class Solution
    {
        public int NumWaterBottles(int numBottles, int numExchange)
        {
            int count = numBottles;
            while (numBottles > 0) 
            {
                count += numBottles / numExchange;
                numBottles = (numBottles / numExchange) + (numBottles % numExchange);
                if (numBottles < numExchange) break;
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
