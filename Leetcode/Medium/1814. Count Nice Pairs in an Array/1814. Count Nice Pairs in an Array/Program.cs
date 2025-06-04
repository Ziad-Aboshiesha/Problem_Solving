public class Solution
{
    public int CountNicePairs(int[] nums)
    {
        long count = 0;
        const int MOD = 1_000_000_007;
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
            count = (count + ((long)item.Value * (item.Value - 1) / 2) % MOD) % MOD;

        }

        return (int)count;
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