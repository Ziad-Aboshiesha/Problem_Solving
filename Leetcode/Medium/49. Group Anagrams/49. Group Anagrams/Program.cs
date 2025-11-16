namespace _49._Group_Anagrams
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> result = new List<IList<string>>();
            Dictionary<string,int> counts = new Dictionary<string,int>();
            foreach (string str in strs) 
            {
                int[]temp = new int[26];
                foreach (char c in str) 
                {
                    temp[c - 'a']++;
                }
                string key = string.Join(",", temp);
                if (counts.ContainsKey(key))
                {
                    result[counts[key]].Add(str);
                }
                else
                {
                    int idx = result.Count;
                    result.Add(new List<string>() {str});
                    counts.Add(key, idx);
                }
            }


            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            IList<IList<string>> r = s.GroupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]);
            for (int i = 0; i < r.Count; i++)
            {
                for (global::System.Int32 j = 0; j < r[i].Count; j++)
                {
                    Console.Write(r[i][j]);
                }
                Console.WriteLine();
            }

        }
    }
}
