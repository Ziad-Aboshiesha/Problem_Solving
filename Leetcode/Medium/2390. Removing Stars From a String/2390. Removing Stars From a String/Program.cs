using System.Text;

namespace _2390._Removing_Stars_From_a_String
{
    public class Solution
    {
        public string RemoveStars(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '*')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(s[i]);

                }
            }
            StringBuilder sb = new StringBuilder();
            while (stack.Count > 0) 
            {
                sb.Insert(0, stack.Pop());
            }
            return sb.ToString();
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
