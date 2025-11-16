namespace _389._Find_the_Difference
{
    public class Solution
    {
        public char FindTheDifference(string s, string t)
        {
            char ans = '\0';
            int[] first = new int[26];
            int[] second= new int[26];
            for(int i = 0;i<s.Length;i++)
            {
                first  [ s[i] - 'a' ]++;
                second [t[i] - 'a']++;

            }
            second[t[t.Length -1 ] - 'a']++;
            for (int i = 0;i<first.Length;i++)
            {
                if (first[i]!= second[i])
                {
                    ans = (char)(i + (int)'a');
                    break;
                }
            }
            return ans;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            s.FindTheDifference("abcd", "abcde");
        }
    }
}
