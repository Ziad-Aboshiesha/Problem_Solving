namespace _441._Arranging_Coins
{
    public class Solution
    {
        //* time : o(1)
        //* space : o(1)

        public int ArrangeCoins(int n)
        {
            return (int)Math.Floor((Math.Sqrt(8L * n + 1) - 1) / 2);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
