namespace _500._Keyboard_Row
{
    internal class Program
    {
        public class Solution
        {
            public string[] FindWords(string[] words)
            {
                HashSet<char> row1 = new HashSet<char>("qwertyuiop");
                HashSet<char> row2 = new HashSet<char>("asdfghjkl");
                HashSet<char> row3 = new HashSet<char>("zxcvbnm");
                List<string> list = new List<string>();
                int current = 0;
                foreach (string word in words)
                {
                    if (word.Length == 1)
                    {
                        list.Add(word);
                        continue;
                    }
                        if (row1.Contains(char.ToLower(word[0]))) current = 1;
                    if (row2.Contains(char.ToLower(word[0]))) current = 2;
                    if (row3.Contains(char.ToLower(word[0]))) current = 3;

                    for (int i = 1; i < word.Length; i++)
                    {
                        if(    (current == 1 && row1.Contains(char.ToLower(word[i])))  
                            || (current == 2 && row2.Contains(char.ToLower(word[i]))) 
                            || (current == 3 && row3.Contains(char.ToLower(word[i])))
                            )
                        {
                            if( i == word.Length -1)
                            {
                                list.Add(word);
                            }
                            continue;
                        } 
                        break;
                    }

                }
                return list.ToArray();  

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
