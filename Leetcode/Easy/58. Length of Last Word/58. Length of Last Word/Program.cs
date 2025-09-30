namespace _58._Length_of_Last_Word
{

    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            int start = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if(s[i] != ' ')
                {

                    start = i;
                    break;
                }
                
            }
            int count = 0;
            for (int i = start; i >= 0; i--)
            {
                if(s[i]== ' ')
                {
                    break;
                }
                else
                {
                    count++;
                }
            }
            return count;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.LengthOfLastWord("Hello World"));
        }
    }
}
