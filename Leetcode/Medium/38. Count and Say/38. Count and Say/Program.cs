namespace _38._Count_and_Say
{
    public class Solution
    {
        public string CountAndSay(int n)
        {
            string s = "";
            string result = "";
            for (int i = 0; i < n; i++)
            {
                if (s == "")
                {
                    s = "1";
                    continue;
                }
                if (s == "1")
                {
                    s = "11";
                    continue;
                }
                int occ = 1;
                char temp = s[0];
                result = "";
                for (int j = 0; j < s.Length - 1; j++)
                {
                    if (s[j + 1] == temp)
                    {
                        occ++;
                        continue;
                    }
                    else
                    {
                        for (int k = 0; k < occ; k++)
                        {
                            result = temp + result;
                        }
                        temp = s[j + 1];
                        occ = 1;
                    }
                }
                s = result;
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.CountAndSay(4));
        }
    }
}
