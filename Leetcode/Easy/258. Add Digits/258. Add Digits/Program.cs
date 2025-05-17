namespace _258._Add_Digits
{

    public class Solution
    {
        // time  : O(log n) 
        // space : O(1)
        public int AddDigits(int num)
        {
            int sum = 11;
            while (sum >= 10)
            {
                sum = 0;
                while (num != 0)
                {
                    int temp = num % 10;
                    sum += temp;
                    num = num / 10;
                }
                num = sum;
            }


            return sum;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
