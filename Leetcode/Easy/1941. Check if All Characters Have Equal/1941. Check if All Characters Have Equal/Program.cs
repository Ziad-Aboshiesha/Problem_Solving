namespace _1941._Check_if_All_Characters_Have_Equal
{

    public class Solution
    {
        public bool AreOccurrencesEqual(string s)
        {
            int[] chars = new int[26];
            int temp = 0;
            for (int i = 0; i < s.Length; i++)
            {
                chars[s[i] - 'a']++;
                temp = Math.Max(temp, chars[s[i] - 'a']);
            }
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] !=0  && chars[i] != temp)
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
