namespace _2544._Alternating_Digit_Sum
{
    public class Solution
    {
        public int AlternateDigitSum(int n)
        {
            int ans = 0;
            List<int> list = new List<int>();
            while(n!= 0 )
            {
                list.Add(n%10);
                n = n/10;
            }
            int sign = 1;
            if (list.Count % 2 == 0) 
            {
                sign = -1;
            }
            for (int i = 0; i < list.Count; i++)
            {
                ans += sign * list[i];
                sign *= -1;
            }
            return ans;
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
