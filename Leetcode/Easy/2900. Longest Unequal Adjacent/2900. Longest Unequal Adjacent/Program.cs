namespace _2900._Longest_Unequal_Adjacent
{
    public class Solution
    {
        // time  : O(n)
        // space : O(n)
        public IList<string> GetLongestSubsequence(string[] words, int[] groups)
        {
            IList<string> result = new List<string>();
            result.Add(words[0]);
            for (int i = 0; i < groups.Length - 1; i++)
            {
                if (groups[i] != groups[i+1])
                {
                    result.Add(words[i + 1]);
                }
            }

            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            IList<string> ans = solution.GetLongestSubsequence(["a", "b", "c", "d", "e", "f", "g", "h"], [1, 0, 1, 1, 0, 1, 0, 1]);
            for (int i = 0; i < ans.Count; i++)
            {
                Console.Write(ans[i] + " ");
            }
        }
    }
}
