
using System;
Solution s = new Solution();

int[] result = s.MissingRolls([4,5,6,2,3,6,5,4,6,4,5,1,6,3,1,4,5,5,3,2,3,5,3,2,1,5,4,3,5,1,5],4,40);
System.Console.WriteLine(result.Sum());
public class Solution
{
    public int[] MissingRolls(int[] rolls, int mean, int n)
    {
        int total = mean * (rolls.Length + n);
        int needed = total - rolls.Sum();
        int[] result = new int[n];
        

        if (needed > n * 6 || needed < n * 1)
        {
            return [];
        }
        for (int i = 0; i < result.Length; i++)
        {
            if ((needed - 1) <= (n - 1) * 6)
            {
                result[i] = 1;
                needed -= 1;
                n -= 1;
                continue;
            }
            if ((needed - 2) <= (n - 1) * 6)
            {
                result[i] = 2;
                needed -= 2;
                n -= 1;
                continue;
            }
            if ((needed - 3) <= (n - 1) * 6)
            {
                result[i] = 3;
                needed -= 3;
                n -= 1;
                continue;
            }
            if ((needed - 4) <= (n - 1) * 6)
            {
                result[i] = 4;
                needed -= 4;
                n -= 1;
                continue;
            }
            if ((needed - 5) <= (n - 1) * 6)
            {
                result[i] = 5;
                needed -= 5;
                n -= 1;
                continue;
            }
            if ((needed - 6) <= (n - 1) * 6)
            {
                result[i] = 6;
                needed -= 6;
                n -= 1;
                continue;
            }
        }
        return result;

    }
}