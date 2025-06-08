Solution s = new Solution();
IList<int> r = s.LexicalOrder(130);
for (int i = 0; i < r.Count; i++)
{
    System.Console.WriteLine(r[i]);
}
public class Solution
{
    public IList<int> LexicalOrder(int n)
    {
        List<int> result = new(n);
        int curr = 1;

        for (int i = 0; i < n; i++)
        {
            result.Add(curr);

            if (curr * 10 <= n)
            {
                curr *= 10; // Go deeper
            }
            else
            {
                // Next sibling or backtrack
                if (curr >= n)
                    curr /= 10;

                curr += 1;

                while (curr % 10 == 0)
                    curr /= 10;
            }
        }

        return result;
    }
}
