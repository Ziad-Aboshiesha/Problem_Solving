namespace _151._Reverse_Words_in_a_String
{
    public class Solution
    {
        public string ReverseWords(string s)
        {
            string temp = "";
            List<string> words = new List<string>();
            for (int i = 0; i < s.Length; i++) 
            {
                if(s[i] == ' ')
                {
                    if(temp.Length > 0)
                    {
                        words.Add(temp);
                    }
                    temp = "";
                }
                else
                {
                    temp += s[i];
                }
            }
            if (temp.Length > 0) 
            {
                words.Add(temp);
            }
            string result = "";
            for (int i = words.Count - 1; i>=0; i--) 
            {
                result += words[i] ;
                if(i!= 0 )
                {
                    result += " ";
                }
            }
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
