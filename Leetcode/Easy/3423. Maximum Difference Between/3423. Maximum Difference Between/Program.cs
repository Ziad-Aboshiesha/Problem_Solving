public class Solution {
    public int MaxAdjacentDistance(int[] nums) {
        int diff = 0;
        for(int i = 0 ; i < nums.Length - 1; i++)
        {
            diff = Math.Max(diff, Math.Abs(nums[i+1] - nums[i]));
        }
        
        diff = Math.Max(diff, Math.Abs(nums[nums.Length - 1 ] - nums[0]));
        
        return diff;
    }
}