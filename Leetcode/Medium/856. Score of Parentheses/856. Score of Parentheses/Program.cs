namespace _856._Score_of_Parentheses
{

    public class Solution
    {
        // time  : O(n)
        // space : O(n)
        public int ScoreOfParentheses(string s)
        {
            int score = 0;
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (stack.Count == 0 || s[i] == '(')
                {
                    stack.Push(s[i]);
                    continue;
                }
                else
                {
                    stack.Pop();
                    if (s[i - 1] == '(')
                    {
                        score += (int)Math.Pow(2, stack.Count);
                    }
                }
            }
            return score;
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
