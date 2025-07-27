namespace _1717._Maximum_Score_From_Removing_Substrings
{
    public class Solution
    {
        public int MaximumGain(string s, int x, int y)
        {
            int ans = 0;
            string higher, lower;

            // decide which pair is higher value
            if (x > y)
            {
                higher = "ab";
                lower = "ba";
            }
            else
            {
                higher = "ba";
                lower = "ab";
            }

            // First pass: remove higher-value pairs
            Stack<char> st = new Stack<char>();
            foreach (char c in s)
            {
                if (st.Count > 0 && st.Peek() == higher[0] && c == higher[1])
                {
                    st.Pop();
                    ans += Math.Max(x, y);
                }
                else
                {
                    st.Push(c);
                }
            }

            // Build remaining string from stack (reverse order)
            List<char> remainList = new List<char>();
            while (st.Count > 0)
                remainList.Add(st.Pop());
            remainList.Reverse();
            string remain = new string(remainList.ToArray());

            // Second pass: remove lower-value pairs
            st = new Stack<char>();
            foreach (char c in remain)
            {
                if (st.Count > 0 && st.Peek() == lower[0] && c == lower[1])
                {
                    st.Pop();
                    ans += Math.Min(x, y);
                }
                else
                {
                    st.Push(c);
                }
            }

            return ans;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.MaximumGain("aabbrtababbabmaaaeaabeawmvaataabnaabbaaaybbbaabbabbbjpjaabbtabbxaaavsmmnblbbabaeuasvababjbbabbabbasxbbtgbrbbajeabbbfbarbagha",8484,4096));
        }
    }
}
