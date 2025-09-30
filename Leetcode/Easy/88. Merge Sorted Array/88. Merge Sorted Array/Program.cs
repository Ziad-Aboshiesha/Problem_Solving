namespace _88._Merge_Sorted_Array
{
    public class Solution
    {
        // time  : O(n + m)
        // space : O(1)
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;
            while (i >= 0 && j >= 0) 
            {
                if(nums1[i] < nums2[j])
                {
                    nums1[k] = nums2[j];
                    j--;
                }
                else
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                k--;
            }
            while(j>=0)
            {
                nums1[k] = nums2[j];
                j--;
                k--;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
