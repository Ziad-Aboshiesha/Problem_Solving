public class Solution
{
    public string RemoveDuplicates(string s, int k)
    {
        string res = "";
        Stack<special> ans = new Stack<special>();
        for (int i = 0; i < s.Length; i++)
        {
            if (ans.Count == 0)
            {
                ans.Push(new special(s[i]));
            }
            else
            {
                special temp = ans.Peek();
                if (s[i] == temp.c)
                {
                    temp.count++;
                    if (temp.count == k)
                    {
                        ans.Pop();
                    }
                }
                else
                {
                    ans.Push(new special(s[i]));
                }
            }
        }
        while (ans.Count != 0)
        {
            special temp = ans.Pop();
            for (int i = 0; i < temp.count; i++)
            {
                res += temp.c;
            }
        }
        return res;
    }
}
public class special
{
    public char c= '\0';
    public int count = 0;
    public special(char c)
    {
        this.c = c;
        count = 1;
    }
}