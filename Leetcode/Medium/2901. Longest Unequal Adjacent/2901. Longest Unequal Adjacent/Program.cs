
namespace _2901._Longest_Unequal_Adjacent
{
    public class Solution
    {
        // time  : O(n*n*m) 
        // space : O(n)
        public IList<string> GetWordsInLongestSubsequence(string[] words, int[] groups)
        {
            IList<string> result = new List<string>();
            if(words.Length == 1)
            {
                result.Add(words[0]);
                return result;
            }
            // dp for memoization to store next big element 
            int[,]dp = new int[groups.Length,2]; //  how many items can we reach if we start from here, what is index of next one
            dp[groups.Count() - 1, 0] = 0; // can go to zero items
            dp[groups.Count() - 1, 1] = -1;  

            for (int i = groups.Count() - 1; i >= 0; i --)
            {

                int count = 0;
                int position = -1;
                for (int j = i + 1; j < groups.Count(); j++)
                {
                    int count_hamming = 0;
                    if (words[i].Length == words[j].Length && groups[i] != groups[j])
                    {
                        for (int k = 0; k < words[i].Length; k++)
                        {
                            if (words[i][k] != words[j][k])
                            {
                                count_hamming += 1;
                            }
                        }
                        
                        if (count_hamming ==1 && dp[j,0] + 1 > count )
                        {
                            count = dp[j, 0] + 1;
                            position = j;
                        }
                    }
                }
                dp[i, 0] = count;
                dp[i, 1] = position; 
            }
            int max = -1;
            int pos_of_max = -1;
            int next = -1;
            for (int i = 0; i < dp.GetLength(0); i++)
            {
                if (dp[i,0] > max)
                {
                    max = dp[i,0];
                    pos_of_max = i;
                    next = dp[i,1];
                     
                }
            }
            //Console.WriteLine(max + " " + pos_of_max + " " + next);
            while(max >= 0)
            {
                result.Add(words[pos_of_max]);
                pos_of_max = dp[pos_of_max,1];
                max--;
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            IList<string> words = solution.GetWordsInLongestSubsequence(
                ["adbe", "acace"], 
                [9,9]);
            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
