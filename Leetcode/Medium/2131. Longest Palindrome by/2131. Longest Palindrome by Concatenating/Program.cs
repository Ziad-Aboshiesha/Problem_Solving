
using System.Collections;
using System;
using System.Security.AccessControl;
Solution s = new Solution();
Console.WriteLine(s.LongestPalindrome(["ll","lb","bb","bx","xx","lx","xx","lx","ll","xb","bx","lb","bb","lb","bl","bb","bx","xl","lb","xx"]));
public class Solution {
    public int LongestPalindrome(string[] words)
    {
        int result = 0;
        bool status = false;
        Dictionary<string, int> strings_freequency = new Dictionary<string, int>();
        for (int i = 0; i < words.Length; i++)
        {
            if (strings_freequency.ContainsKey(words[i]))
            {
                strings_freequency[words[i]] += 1;
            }
            else
            {
                strings_freequency[words[i]] = 1;
                
            }
        }
        foreach (KeyValuePair<string, int> s in strings_freequency)
        {
            if (s.Key[0] != s.Key[1])
            {
                string flipped = s.Key[1].ToString() + s.Key[0].ToString();
                if (strings_freequency.ContainsKey(flipped))
                {
                    result += Math.Min(strings_freequency[flipped], strings_freequency[s.Key]);
                }
            }
            else
            {
                if (strings_freequency[s.Key] % 2 == 1)
                {
                    status = true;
                    result += strings_freequency[s.Key] - 1;
                }
                else
                {
                    result += strings_freequency[s.Key] ;
                }
            }
        }
        result *= 2;
        if (status)
        {
            result += 2;
        }
        return result;
    }
}