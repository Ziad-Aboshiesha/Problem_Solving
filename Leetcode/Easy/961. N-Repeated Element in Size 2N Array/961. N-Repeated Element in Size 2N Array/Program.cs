public class Solution {
    public int RepeatedNTimes(int[] nums)
    {
        HashSet<int> numbers = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (numbers.Contains(nums[i]))
            {
                return nums[i];
            }
            numbers.Add(nums[i]);

        }
        return -1;    
    }
}