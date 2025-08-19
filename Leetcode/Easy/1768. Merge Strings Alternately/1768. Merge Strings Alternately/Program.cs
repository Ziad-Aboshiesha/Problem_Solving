namespace _1768._Merge_Strings_Alternately
{
    public class Solution
    {
        public string MergeAlternately(string word1, string word2)
        {
            string result = "";
            int i = 0, j = 0;
            while (i < word1.Length && j < word2.Length)
            {
                result += word1[i];
                result += word2[j];

                i++;
                j++;
            }
            while (i < word1.Length)
            {
                result += word1[i];
                i++;
            }
            while (j < word2.Length)
            {
                result += word2[j];
                j++;
            }
            return result;

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
