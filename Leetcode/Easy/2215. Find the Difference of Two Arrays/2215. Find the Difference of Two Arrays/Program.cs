namespace _2215._Find_the_Difference_of_Two_Arrays
{
    public class Solution
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            HashSet<int> one = nums1.ToHashSet();
            HashSet<int> two = nums2.ToHashSet();

            List<IList<int>> result = new List<IList<int>>();
            result.Add(new List<int>()); 
            result.Add(new List<int>()); 

            foreach (var item in one)
            {
                if (!two.Contains(item))
                {
                    result[0].Add(item);
                }
            }
            foreach (var item in two)
            {
                if (!one.Contains(item))
                {
                    result[1].Add(item);
                }
            }
            return result;
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
