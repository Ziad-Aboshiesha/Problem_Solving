Solution s = new Solution();
int[] r = s.FindOriginalArray([0,0,0,0]);
for (int i = 0; i < r.Length; i++)
{
    System.Console.WriteLine(r);
}
    
public class Solution
{
    public int[] FindOriginalArray(int[] changed)
    {
        if (changed.Length <= 1) return [];
        List<int> r = new List<int>();
        List<int> result = changed.ToList();
        result.Sort();
        Dictionary<int, int> visited = new();
        for (int i = 0; i < result.Count; i++)
        {
            visited.TryAdd(result[i], 0);
            visited[result[i]]++;
        }
        if ((visited.Count == 1  && !visited.ContainsKey(0))|| (visited.ContainsKey(0) && visited[0]%2 == 1)) return [];
        for (int i = 0; i < result.Count; i++)
        {
            if (visited.ContainsKey(result[i]) && visited.ContainsKey(result[i] * 2))
            {
                r.Add(result[i]);
                visited[result[i]]--;
                if (visited[result[i]] == 0)
                    visited.Remove(result[i]);

                visited[result[i] * 2]--;
                if (visited[result[i] * 2] == 0)
                    visited.Remove(result[i] * 2);

            }
        }
        if (visited.Count > 0) { return []; }
        return r.ToArray();
    }
}
