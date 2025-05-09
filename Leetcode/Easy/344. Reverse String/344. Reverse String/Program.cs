namespace _344._Reverse_String
{
    public class Solution
    {
        // time  : O(n)
        // space : O(1)
        public void ReverseString(char[] s)
        {

            for (int i = 0; i < s.Length / 2; i++)
            {
                char temp = s[i];
                s[i] = s[s.Length - i - 1];
                s[s.Length - i - 1] = temp;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
