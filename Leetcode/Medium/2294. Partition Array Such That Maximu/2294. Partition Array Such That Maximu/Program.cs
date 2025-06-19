public class Solution {
    public int PartitionArray(int[] nums, int k)
    {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return 1;
        Array.Sort(nums);
        int ans = 1;
        int current = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] - current > k)
            {
                ans++;
                current = nums[i];
            }
        }
        return ans;
    }
}