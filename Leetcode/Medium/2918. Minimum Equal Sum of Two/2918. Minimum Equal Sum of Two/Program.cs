namespace _2918._Minimum_Equal_Sum_of_Two
{
    public class Solution
    {
        // time  : O(n+m)
        // space : O(1)
        public long MinSum(int[] nums1, int[] nums2)
        {
            long count = 0;
            long sum1 = 0;
            long sum2 = 0;
            long count_zeros1 = 0;
            long count_zeros2 = 0;
            //find sum and count zeros
            for (int i = 0; i < nums1.Length; i++)
            {
                sum1 += nums1[i];
                if (nums1[i] == 0)
                {
                    count_zeros1 += 1;
                }
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                sum2 += nums2[i];
                if (nums2[i] == 0)
                {
                    count_zeros2 += 1;
                }
            }
            //Console.WriteLine(sum1 + " " + sum2 + " " + count_zeros1 + " " + count_zeros2 );
            //handle case if sums are equal
            if(sum1 == sum2)
            {
                if ((count_zeros1 == 0 && count_zeros2 != 0) || (count_zeros1 != 0 && count_zeros2 == 0))
                {
                    return -1;
                }
                return sum1 + Math.Max(count_zeros1, count_zeros2);
               
            }
            //if not equal
            else
            {
                if (
                        (sum1 > sum2 && count_zeros2 == 0) || (sum1 < sum2 && count_zeros1 == 0)
                    ||  (sum1 > sum2 && count_zeros2 > sum1 - sum2 && count_zeros1 == 0)
                    ||  (sum1 < sum2 && count_zeros1 > sum2 - sum1 && count_zeros2 == 0)
                    )
                    return -1;

                else
                {
                    count = Math.Max(sum1 + count_zeros1, sum2 + count_zeros2);
                }
            }


            return count;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.MinSum([2, 0, 2, 0], [1, 4]));
        }
    }
}
