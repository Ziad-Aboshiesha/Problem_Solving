namespace _242._Valid_Anagram
{

    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            if(s.Length!=t.Length) return false;
            int[] first = new int[26];
            int[] second = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                first[s[i] - 'a'] += 1;
                second[t[i] - 'a'] += 1;

            }
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])return false;
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
