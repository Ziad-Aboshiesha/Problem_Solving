using System.Text;

namespace _880._Decoded_String_at_Index
{
    internal class Program
    {
        public class Solution
        {
            public string DecodeAtIndex(string s, int k)
            {
                long size = 0;

                // Step 1: Compute total length using long
                foreach (char c in s)
                {
                    if (char.IsDigit(c))
                    {
                        size *= c - '0';
                    }
                    else
                    {
                        size++;
                    }
                }

                long K = k; // work with long

                // Step 2: Work backwards
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    char c = s[i];
                    if (char.IsDigit(c))
                    {
                        size /= c - '0';
                        K %= size;  // important: use long
                    }
                    else
                    {
                        if (K == 0 || K == size)
                        {
                            return c.ToString();
                        }
                        size--;
                    }
                }

                return "";
            }
        }

        static void Main(string[] args)
        {
           Solution s = new Solution();
            Console.WriteLine(s.DecodeAtIndex("leet2code3",10));
        }
    }
}
