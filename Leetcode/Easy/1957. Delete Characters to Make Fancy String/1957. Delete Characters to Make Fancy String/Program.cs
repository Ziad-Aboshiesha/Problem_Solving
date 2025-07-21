namespace _1957._Delete_Characters_to_Make_Fancy_String
{
    public class Solution
    {
        public string MakeFancyString(string s)
        {
            int count = 1;
            char current = s[0];
            List<char> result = s.ToList();
            for (int i = 1; i < result.Count; i++)
            {
                if (result[i] == current)
                {
                    count++;
                }
                else
                {
                    if (count >= 3)
                    {
                        int tobedeleted = count - 2;
                        result.RemoveRange(i - tobedeleted, tobedeleted);
                        i = i - tobedeleted;
                    }
                    count = 1;
                    current = result[i];
                }
            }

            // after loop, check last run
            if (count >= 3)
            {
                int tobedeleted = count - 2;
                result.RemoveRange(result.Count - tobedeleted, tobedeleted);
            }

            // ✅ convert List<char> to char[]
            return new string(result.ToArray());
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
