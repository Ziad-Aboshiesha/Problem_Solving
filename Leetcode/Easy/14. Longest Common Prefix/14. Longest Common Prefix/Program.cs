namespace _14._Longest_Common_Prefix
{
    // time  : O(m*n)
    // space : O(1)
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            int len = strs.Length;
            string first = strs[0];
            int count = 100;
            for (int i = 1; i < len; i++)
            {
                int j = 0;
                string second = strs[i];
                int insider_count = 0;
                while (j < first.Length && j < second.Length)
                {
                    if (first[j] == second[j])
                    {
                        insider_count++;
                        j++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (insider_count < count) count = insider_count;
            }
            if (strs.Length == 1)
            {
                count = first.Length;
            }

            return (first.Substring(0, count));


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
