using System.Collections.Immutable;

public class Solution {
    public int MissingNumber(int[] nums)
    {
        HashSet<int> ints = nums.ToHashSet<int>();
        for (int i = 0; i <= nums.Length; i++)
        {
            if (!ints.Contains(i))
            {
                return i;
            }
        }
        return -1;
    }
}