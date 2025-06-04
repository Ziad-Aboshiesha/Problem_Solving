public class Solution {
    public bool QueryString(string s, int n)
    {
        for (int i = 1; i <= n; i++)
        {
            string binary = Convert.ToString(i, 2);
            if (!s.Contains(binary))
            {
                return false;
            }
        }
        return true;
    }
}