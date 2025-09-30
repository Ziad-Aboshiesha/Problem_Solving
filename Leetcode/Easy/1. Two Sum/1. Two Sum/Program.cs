namespace _1._Two_Sum
{
    //public class Solution
    //{
    //    // time  : O(n**2)
    //    // space : O(1)
    //    public int[] TwoSum(int[] nums, int target)
    //    {
    //        int[] result = new int[2];
    //        for (int i = 0; i < nums.Length; i++)
    //        {

    //            for (int j = i + 1; j < nums.Length; j++)
    //            {

    //                if (nums[i] + nums[j] == target)
    //                {

    //                    result[0] = i;
    //                    result[1] = j;
    //                    return result;
    //                }
    //            }

    //        }
    //        return result;
    //    }
    //}
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length ==2)
            {
                return new int[] { 0, 1 };                
            }
            Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();
            for (int i = 0; i < nums.Length; i++) 
            {
                int temp = target - nums[i];
                if(keyValuePairs.ContainsKey(temp))
                {
                    return  new int[] { keyValuePairs[temp], i };
                }
                keyValuePairs.TryAdd(nums[i], i);
            }
            return new int []{ 0,0};
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.TwoSum([3, 2, 4], 6);
        }
    }
}
