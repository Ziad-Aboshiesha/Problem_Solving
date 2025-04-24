using System.Collections;

namespace _2799._Count_Complete_Subarrays_in_an_Array
{

    public class Solution
    {
        #region

        /*
         * 
         * function: CountCompleteSubarrays
         * description :    You are given an array nums consisting of positive integers.

                            We call a subarray of an array complete if the following condition is satisfied:

                            The number of distinct elements in the subarray is equal to the number of distinct elements in the whole array.
                            Return the number of complete subarrays.

                            A subarray is a contiguous non-empty part of an array.

 

                            Example 1:

                            Input: nums = [1,3,1,2,2]
                            Output: 4
                            Explanation: The complete subarrays are the following: [1,3,1,2], [1,3,1,2,2], [3,1,2] and [3,1,2,2].
         * edge cases : 
         * inputs : int[] nums
         * outputs : count of subarrays
         * approach : find distinct element in original subarray, apply dynamic sliding window
         * time : o(n)
         * space : o(k) k is number of distinct element in array which have worst case n 

        */

        #endregion

        public int CountCompleteSubarrays(int[] nums)
        {
            int count = 0;
            HashSet<int> result = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                result.Add(nums[i]);
            }
            int distinct = result.Count;
            Dictionary<int , int> dict = new Dictionary<int, int>();
            int left = 0 ;
            for (int right = 0; right < nums.Length; right++)
            {
                if (!dict.ContainsKey(nums[right]))
                {
                    dict[nums[right]] = 1;
                }
                else
                {
                    dict[nums[right]] = dict[nums[right]] + 1;
                }
                while(dict.Count >= distinct)
                {
                    count += nums.Length - right;
                    if (dict[nums[left]] > 1)
                        dict[nums[left]] = dict[nums[left]] - 1;
                    else
                        dict.Remove(nums[left]);
                    left++;
                }
            }


            return count;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.CountCompleteSubarrays([5,5,5,5]));
        }

    }
}
