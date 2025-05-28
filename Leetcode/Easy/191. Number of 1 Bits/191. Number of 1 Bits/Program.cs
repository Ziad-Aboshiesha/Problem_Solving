using System;
Solution s = new Solution();
Console.WriteLine(s.HammingWeight(11));
public class Solution
{
    public int HammingWeight(int n)
    {
        int result = 0;
        string binaryString = Convert.ToString(n, 2);
        for (int i = 0; i < binaryString.Length; i++)
        {
            if (binaryString[i] == '1')
            {
                result++;
            }
        }
        return result;
    }
}