public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        HashSet<int> one = nums1.ToHashSet();
        HashSet<int> two = nums2.ToHashSet();
        if (one.Count() > two.Count())
        {
            return compare(one, two).ToArray();
        }
        else
        {
            return compare( two, one).ToArray();
            
        }
    }
    public HashSet<int> compare(HashSet<int> big, HashSet<int> small)
    {
        foreach (var item in small)
        {
            if (!big.Contains(item))
            {
                small.Remove(item);
            }
        }
        return small;
    }
}