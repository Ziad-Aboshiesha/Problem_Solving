public class Solution {
    public int MaxFrequencyElements(int[] nums)
    {
        int highest_freq = 0;
        int count_highest_freq = 0;
        Dictionary<int, int> freq = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            freq.TryAdd(nums[i], 0);
            freq[nums[i]]++;
            highest_freq = Math.Max(highest_freq, freq[nums[i]]);
        }
        foreach (var item in freq)
        {
            if (item.Value == highest_freq) count_highest_freq++;
        }
        return highest_freq * count_highest_freq;       
    }
}