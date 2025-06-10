public class Solution
{
    public int MaxDifference(string s)
    {
        int[] freq = new int[26];
        foreach (var item in s)
        {
            freq[item -'a']++;
        }
        int  max_odd = 0, min_even = int.MaxValue;
        for (int i = 0; i < 26; i++)
        {
            
            if (freq[i] != 0 && freq[i] % 2 == 0 && freq[i] < min_even)
            {
                min_even = freq[i];
            }
        
            if (freq[i] % 2 != 0 && freq[i] > max_odd)
            {
                max_odd = freq[i];
            }
        }
        return  max_odd - min_even;
    }
}