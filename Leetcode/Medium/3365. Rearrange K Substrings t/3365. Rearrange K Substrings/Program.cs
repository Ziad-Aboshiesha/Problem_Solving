using System;
Solution s = new Solution();
Console.WriteLine(s.IsPossibleToRearrange("aabbcc", "bbaacc",  2));

public class Solution
{
    // time : O(n)
    // space : O(n)
    public bool IsPossibleToRearrange(string s, string t, int k)
    {
        int divider = s.Length / k;
        if (s.Length != t.Length) return false;
        if (s == t) return true;
        Dictionary<string, int> strings = new Dictionary<string, int>();
        for (int i = 0; i < t.Length; i += divider)
        {
            string temp = t.Substring(i, divider);
            if (strings.ContainsKey(temp))
            {
                strings[temp] += 1;

            }
            else
            {
                strings[temp] = 1;

            }
        }
        for (int i = 0; i < s.Length; i += divider)
        {
            string temp = s.Substring(i, divider);
            if (strings.ContainsKey(temp))
            {
                if (strings[temp] > 1)
                {

                    strings[temp] -= 1;
                }
                else
                {
                    strings.Remove(temp);
                }
                continue;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}
