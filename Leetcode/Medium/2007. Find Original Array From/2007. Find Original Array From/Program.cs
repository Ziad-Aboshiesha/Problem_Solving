namespace _2007._Find_Original_Array_From
{
    public class Solution
    {
        public int[] FindOriginalArray(int[] changed)
        {
            List<int> r = new List<int>();
            List<int> result = changed.ToList();
            result.Sort();
            HashSet<int> visited = result.ToHashSet();
            for (int i = 0; i < result.Count; i++)
            {
                if (visited.Contains(result[i] ) && visited.Contains(result[i] *2))
                {
                    r.Add(result[i]);
                    visited.Remove(result[i]);
                    visited.Remove(result[i] * 2);

                }
            }
            if (visited.Count > 0) { return []; }
            return r.ToArray();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.FindOriginalArray([1, 3, 4, 2, 6, 8]);
        }
    }
}
