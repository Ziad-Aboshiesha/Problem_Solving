Solution s = new Solution();
System.Console.WriteLine(s.MinDeletions("aaabbbcc"));
public class Solution
{
    public int MinDeletions(string s)
    {
        Dictionary<char, int> count = new();
        Dictionary<int, int> freq = new();
        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            count.TryAdd(s[i], 0);
            count[s[i]]++;
        }
        foreach (var item in count)
        {
            freq.TryAdd(item.Value, 0);
            freq[item.Value]++;
        }
        foreach (var item in count)
        {
            if (freq[item.Value] < 2)
            {
                continue;
            }
            else
            {
                for (int i = item.Value - 1; i >= 0; i--)
                {
                    if (!freq.ContainsKey(i))
                    {
                        result += item.Value - i;
                        if (i != 0)
                        {
                            freq.Add(i, 1);
                        }
                        freq[item.Value]--;
                        break;
                    }
                }
            }

        }
        return result;
    }
}