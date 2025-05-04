namespace _1128._Number_of_Equivalent_Domino_Pairs
{

    public class Solution
    {
        // time  : O(n)
        // space : O(n)
        public int NumEquivDominoPairs(int[][] dominoes)
        {
            int count = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach (var d in dominoes)
            {
                int a = Math.Min(d[0], d[1]);
                int b = Math.Max(d[0], d[1]);
                int key = a * 10 + b; 

                if (!map.ContainsKey(key))
                    map[key] = 0;

                count += map[key];
                map[key]++;
            }

            return count;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.NumEquivDominoPairs([[1, 2], [2, 1], [3, 4], [5, 6]]));
        }
    }
}
