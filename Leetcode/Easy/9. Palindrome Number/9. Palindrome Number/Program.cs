namespace _9._Palindrome_Number
{
    // time  : O(n)
    // space : O(n)
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            var y = x.ToString();
            for (int i = 0; i < (y.Length / 2); i++)
            {
                if (y[i] != y[y.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
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
