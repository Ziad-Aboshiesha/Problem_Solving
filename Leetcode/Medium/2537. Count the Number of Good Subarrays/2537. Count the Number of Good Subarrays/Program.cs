using System.Collections;

namespace _2537._Count_the_Number_of_Good_Subarrays
{
    public class Solution
    {
        public long CountGood(int[] nums, int k)
        {
            bool status = true;
            if (nums.Length == 1) return 0;
            int number_of_arrays = 0;
            Hashtable hashs = new Hashtable();
            int all = 0;
            int start = 0;
            int end = 0;
            while (end < nums.Length  ) 
            { 

                if (hashs[nums[end]] == null)
                {
                    hashs[nums[end]] = 1;
                    end++;
                    continue;
                }
                else
                {
                    if (status)
                    {
                        hashs[nums[end]] = (int)hashs[nums[end]] + 1;

                        all = all + (int)hashs[nums[end]] - 1;


                    }
                    if (all< k)
                    {

                        end++;
                        status = true;
                    }
                    else
                    {
                        number_of_arrays += nums.Length - end;

                        all -= ((int)hashs[nums[start]] - 1);
                        hashs[nums[start]] = (int)hashs[nums[start]] - 1;
                        start++;
                        status = false;
                    }
                }
            }


            return number_of_arrays  ;


        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(   s.CountGood([3, 1, 4, 3, 2, 2, 4], 2));
        }
    }
}
