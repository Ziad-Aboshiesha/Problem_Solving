Solution s = new Solution();
System.Console.WriteLine(s.RepeatedStringMatch("aaac","aac"));
public class Solution
{
    public int RepeatedStringMatch(string a, string b)
    {
        if (b.Length == 0) return 0;
        if(b.Length < a.Length && a.Contains(b)) return 1;
        char first = b[0];
        int current = -1;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == first)
            {
                current = i;
                break;
            }
        }
        int count = 0;
        if (current == -1) return -1;
        for (int i = 0; i < b.Length; i++)
        {
            // if (current == 0)
            // {
            //     count++;
            // }
            if (b[i] != a[current])
                {
                    return -1;
                }
            if (current == a.Length - 1)
            {
                current = 0;
                count++;
            }
            else
            {
                current++;
            }

        }
        if (current != 0) count++;
        return count;
    }
}