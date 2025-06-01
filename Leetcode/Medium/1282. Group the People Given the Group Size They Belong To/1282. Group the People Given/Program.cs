Solution s = new Solution();
s.GroupThePeople([3, 3, 3, 3, 3, 1, 3]);
public class Solution
{
    public IList<IList<int>> GroupThePeople(int[] groupSizes)
    {
        Dictionary<int, List<int>> res = new Dictionary<int, List<int>>();
        for (int i = 0; i < groupSizes.Length; i++)
        {
            if (!res.ContainsKey(groupSizes[i]))
            {
                res[groupSizes[i]] = new List<int>();
            }

            res[groupSizes[i]].Add(i);
        }
        List<List<int>> result = new List<List<int>>();
        foreach (KeyValuePair<int, List<int>> item in res)
        {
            if (item.Key == item.Value.Count)
            {
                result.Add(item.Value);
            }
            else
            {
                int partSize = item.Value.Count / item.Key;

                for (int i = 0; i < partSize; i++)
                {
                    result.Add(item.Value.GetRange(i * item.Key, item.Key));
                }
            }
        }
        return result.Cast<IList<int>>().ToList();
    }
}