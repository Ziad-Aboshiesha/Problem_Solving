namespace _3110._Score_of_a_String
{
    public class Solution
    {
        public int ScoreOfString(string s)
        {
            int sum = 0;

            if(s.Length<2) return sum;
            for (int i = 0; i < s.Length -1 ; i++)
            {
                sum += Math.Abs((int)s[i] - (int)s[ i + 1 ]);
            }

            return sum;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Solution s = new Solution();
            Console.WriteLine(s.ScoreOfString("zaz"));
        }
    }
}
