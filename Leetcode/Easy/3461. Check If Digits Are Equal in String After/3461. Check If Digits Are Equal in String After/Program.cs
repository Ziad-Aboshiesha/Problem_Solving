namespace _3461._Check_If_Digits_Are_Equal_in_String_After
{
    public class Solution
    {
        public bool IsStable(string s)
        {
            // Repeat until only 2 digits remain
            while (s.Length > 2)
            {
                char[] next = new char[s.Length - 1];

                for (int i = 0; i < s.Length - 1; i++)
                {
                    int a = s[i] - '0';
                    int b = s[i + 1] - '0';
                    next[i] = (char)(((a + b) % 10) + '0');
                }

                s = new string(next);
            }

            // Compare final 2 digits
            return s[0] == s[1];
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           Solution s = new Solution();
            Console.WriteLine(s.HasSameDigits("3902"));
        }
    }
}
