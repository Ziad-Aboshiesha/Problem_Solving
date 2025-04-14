namespace _20._Valid_Parentheses
{
    public class Solution
    {
        // time  : O(n)
        // space : O(n)
        public bool IsValid(string s)
        {
            if (s.Length <= 1) return false;
            Stack<char> stack = new Stack<char>();
            foreach (var item in s)
            {
                if (stack.Count == 0)
                {
                    stack.Push(item);
                    continue;
                }
                else
                {
                    if ((int)stack.Peek() == (int)item - 1 || (int)stack.Peek() == (int)item - 2)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(item);
                    }
                }
            }
            return stack.Count == 0;
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
