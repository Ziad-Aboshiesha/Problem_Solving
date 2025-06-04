public class Solution {
    public int CountMatchingSubarrays(int[] nums, int[] pattern)
    {
        int count = 0;
        for (int i = 0; i < nums.Length - pattern.Length; i++)
        {
            bool status = true;

            for (int j = 0; j < pattern.Length; j++)
            {
                if (!(pattern[j] == 0 && nums[i + j + 1] == nums[i + j]
                || pattern[j] == -1 && nums[i + j + 1] < nums[i + j]
                || pattern[j] == 1 && nums[i + j + 1] > nums[i + j]))
                {
                    status = false;
                    break;
                }
            }
            if (status)
            {
                count += 1;
            }
        }
        return count;
    }
}