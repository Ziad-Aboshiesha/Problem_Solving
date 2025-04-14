namespace _1047._Remove_All_Adjacent_Duplicates_In_String
{
    public class Solution
    {
        // time  : O(n)
        // space : O(n)
        public string RemoveDuplicates(string s)
        {
            if (s.Length <= 1) return s;

            Stack<char> stack = new Stack<char>();
            foreach (var item in s)
            {
                if (stack.Count == 0 || item != stack.Peek())
                {
                    stack.Push(item);
                }
                else
                {
                    stack.Pop();
                }
            }
            List<char> list = new List<char>();
            while (stack.Count > 0)
            {
                char item = stack.Peek();
                list.Add(item);
                stack.Pop();
            }
            list.Reverse();

            return new string(list.ToArray());

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
