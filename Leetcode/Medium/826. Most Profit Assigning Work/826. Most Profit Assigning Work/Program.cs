namespace _826._Most_Profit_Assigning_Work
{
    public class Solution
    {
        // time  : O(m*n)
        // space : O(1)
        public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker)
        {
            int total = 0;
            for (int i = 0; i < worker.Length; i++)
            {
                int temp = 0;
                for (global::System.Int32 j = 0; j < difficulty.Length; j++)
                {
                    if (worker[i] >= difficulty[j] && profit[j] > temp)
                    {
                        temp = profit[j];
                    }
                }
                total += temp;

            }


            return total;
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
