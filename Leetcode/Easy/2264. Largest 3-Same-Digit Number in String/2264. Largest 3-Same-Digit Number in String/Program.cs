namespace _2264._Largest_3_Same_Digit_Number_in_String
{
    public class Solution
    {
        public string LargestGoodInteger(string num)
        {
            string s = "";
            for(int i = 0;i < num.Length - 2; i++)
            {
                if(num[i] == num[i+1] && num[i+1] == num[i+2] && (s.Length == 0 || s[0] < num[i]))
                {
                   
                        s = num.Substring(i, 3);
                    
                    
                }
            }
            return s ;
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
