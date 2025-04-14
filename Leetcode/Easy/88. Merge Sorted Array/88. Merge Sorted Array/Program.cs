namespace _88._Merge_Sorted_Array
{
    public class Solution
    {
        // time  : O(n + m)
        // space : O(m)
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] temp = new int[m];
            Array.Copy(nums1, temp, m);
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < m && j < n)
            {
                if (temp[i] < nums2[j])
                {
                    nums1[k] = temp[i];
                    i++;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j++;
                }
                k++;
            }
            for (; i < m; i++)
            {
                nums1[k] = temp[i];
                k++;
            }

            for (; j < n; j++)
            {
                nums1[k] = nums2[j];
                k++;
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
