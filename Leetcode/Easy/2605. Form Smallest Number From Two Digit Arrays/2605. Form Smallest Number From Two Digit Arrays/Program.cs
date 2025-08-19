namespace _2605._Form_Smallest_Number_From_Two_Digit_Arrays
{
    public class Solution
    {
        public int MinNumber(int[] nums1, int[] nums2)
        {
            int num1 = int.MaxValue;
            int num2 = int.MaxValue;
            int duplicate = int.MaxValue;
            HashSet<int> result = new HashSet<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                result.Add(nums1[i]);
                if(num1 > nums1[i])
                    num1 = nums1[i];
            }
            bool dup = false;
            for (int i = 0; i < nums2.Length; i++)
            {
                if(result.Contains(nums2[i]))
                {
                    dup = true;
                    duplicate = Math.Min(duplicate, nums2[i]);
                }
                if (num2 > nums2[i])
                    num2 = nums2[i];

            }
            if (dup)
            {
                return duplicate;
            }
            
            
            
            
            
            if (num1 > num2) 
            {
                return num2*10 + num1;
            }
            return num1 * 10 + num2;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.MinNumber([4, 1, 3], [5, 7]));
        }
    }
}
