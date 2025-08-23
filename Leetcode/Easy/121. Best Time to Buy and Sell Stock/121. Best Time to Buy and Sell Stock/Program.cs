namespace _121._Best_Time_to_Buy_and_Sell_Stock
{
    internal class Program
    {
        public class Solution
        {
            public int MaxProfit(int[] prices)
            {
                int max = 0;
                int min = prices[0];
                for (int i = 1; i < prices.Length; i++)
                {
                    if (prices[i] < min)
                    {
                        min = prices[i];
                        continue;
                    }
                    else
                    {
                        max = Math.Max(max, prices[i] - min);
                    }
                }
                return max;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
