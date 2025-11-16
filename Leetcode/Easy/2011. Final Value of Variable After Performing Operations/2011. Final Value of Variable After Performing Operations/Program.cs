namespace _2011._Final_Value_of_Variable_After_Performing_Operations
{

    public class Solution
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            int x = 0;
            for (int i = 0; i < operations.Length; i++)
            {
                if (operations[i][0] == '+' || operations[i][operations[i].Length - 1] == '+')
                {
                    x++;
                }
                if (operations[i][0] == '-' || operations[i][operations[i].Length - 1] == '-')
                {
                    x--;
                }
            }
            return x;
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
