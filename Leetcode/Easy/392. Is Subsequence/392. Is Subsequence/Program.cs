using System.ComponentModel;

namespace _392._Is_Subsequence
{

    public class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            int first = 0 , second = 0 ;
            int count = 0;
            while (first < s.Length && second < t.Length)
            {
                if(s[first] == t[second])
                {
                    first++;
                    second++;
                    count++;
                }
                else
                {
                    second++;
                }
            }
            return count == s.Length;
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.IsSubsequence("axc", "ahbgdc"));
        }
    }
}
