namespace _3._Longest_Substring_Without_Repeating_Characters
{
    internal class Program
    {
        public class Solution
        {
            public int LengthOfLongestSubstring(string s)
            {
                int max = 0;
                int len = 0;
                int left = 0;
                HashSet<char> chars = new HashSet<char>();
                for (int i = 0; i < s.Length; i++)
                {
                    if(!chars.Contains(s[i]))
                    {
                        chars.Add(s[i]);
                        len++;
                    }
                    else
                    {
                        max = Math.Max(max, len);
                        while (s[left] != s[i] && left<s.Length)
                        {
                            chars.Remove(s[left]);
                            len--;
                            left++;
                        }
                        left++;
                    }
                }
                max = Math.Max(max, len);
                return max;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
