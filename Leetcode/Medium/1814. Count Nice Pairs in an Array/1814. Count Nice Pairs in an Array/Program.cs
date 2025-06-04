public class Solution
{
    public int CountNicePairs(int[] nums)
    {
        int count = 0;
        Dictionary<int, int> pairs = new();
        // int[] rev = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            // rev[i] = reverse(nums[i]);
            int temp = nums[i] - reverse(nums[i]);
            pairs.TryAdd(temp, 0);
            pairs[temp] += 1;
        }

        foreach (var item in pairs)
        {
            count += item.Value * (item.Value - 1) / 2;
        }

        return count;
    }
    private int reverse(int x)
    {
        int res = 0;
        while (x != 0)
        {
            int temp = x % 10;
            res = res * 10 + temp;
            x = x / 10;
        }
        return res;
    }
}