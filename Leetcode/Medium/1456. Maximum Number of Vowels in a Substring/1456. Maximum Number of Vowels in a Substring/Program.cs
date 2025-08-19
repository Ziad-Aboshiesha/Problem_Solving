namespace _1456._Maximum_Number_of_Vowels_in_a_Substring
{
    public class Solution
    {
        public int MaxVowels(string s, int k)
        {
            int count = 0;
            int max_count = 0;
            for (int i = 0; i < k; i++)
            {
                if (s[i]== 'a' || s[i] == 'u' || s[i] == 'o' || s[i] == 'i' || s[i] == 'e')
                {
                     count++;
                }
            }
            max_count = Math.Max(max_count, count);
            for (int i = k; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'u' || s[i] == 'o' || s[i] == 'i' || s[i] == 'e')
                {
                    count++;
                }
                if (s[i - k] == 'a' || s[i-k] == 'u' || s[i-k] == 'o' || s[i-k] == 'i' || s[i-k] == 'e')
                {
                    count--;
                }
                max_count = Math.Max(max_count, count);

            }



            return max_count;

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
