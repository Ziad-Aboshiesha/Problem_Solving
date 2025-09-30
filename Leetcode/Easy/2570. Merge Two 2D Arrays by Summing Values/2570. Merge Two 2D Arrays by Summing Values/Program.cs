namespace _2570._Merge_Two_2D_Arrays_by_Summing_Values
{
    internal class Program
    {
        public class Solution
        {
            public int[][] MergeArrays(int[][] nums1, int[][] nums2)
            {
                List<int[]> result = new List<int[]>();
                int idx1=  0, idx2=0;
                while (idx1 < nums1.Length && idx2 < nums2.Length) 
                {
                    if (nums1[idx1][0] == nums2[idx2][0])
                    {
                        result.Add(new int[] { nums2[idx2][0], nums2[idx2][1] + nums1[idx1][1] });
                        idx2++;
                        idx1++;
                    }
                    else if(nums1[idx1][0] > nums2[idx2][0])
                    {
                        result.Add(new int[] { nums2[idx2][0], nums2[idx2][1] });
                        idx2++;
                        
                    }
                    else if (nums1[idx1][0] < nums2[idx2][0])
                    {
                        result.Add(new int[] { nums1[idx1][0], nums1[idx1][1] });
                        idx1++;

                    }
                }
                while(idx1 < nums1.Length)
                {
                    result.Add(new int[] { nums1[idx1][0], nums1[idx1][1] });
                    idx1++;
                }
                while (idx2 < nums2.Length)
                {
                    result.Add(new int[] { nums2[idx2][0], nums2[idx2][1] });
                    idx2++;
                }
                return result.ToArray();

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
