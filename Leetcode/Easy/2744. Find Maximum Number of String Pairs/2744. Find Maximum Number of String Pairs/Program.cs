namespace _2744._Find_Maximum_Number_of_String_Pairs
{
    
    public class Solution
    {

        // time  : O(n * m)
        // space : O(n * m)
        public int MaximumNumberOfStringPairs(string[] words)
        {
            HashSet<string> sol = new HashSet<string>();
            int result = 0;
            foreach (string i in words)
            {
                sol.Add(i);
            }
            foreach (string i in sol)
            {
                char[] chars = i.ToCharArray();
                Array.Reverse(chars);
                string reversed = new string(chars);

                if (sol.Contains(reversed) && reversed[0] != reversed[1])
                {
                    result++;
                }

            }
            result /= 2;



            return result;
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
