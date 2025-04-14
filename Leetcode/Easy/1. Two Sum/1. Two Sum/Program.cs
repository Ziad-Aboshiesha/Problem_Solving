﻿namespace _1._Two_Sum
{
    public class Solution
    {
        // time  : O(n**2)
        // space : O(1)
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                bool x = false;
                for (int j = i+1; j < nums.Length; j++)
                {
                    
                    if (nums[i] + nums[j] == target)
                    {

                        result[0] = i;
                        result[1] = j;
                        x = true;
                        break;
                    }
                }
                if (x)
                {
                    break;
                }
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
