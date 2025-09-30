namespace _1528._Shuffle_String
{
    internal class Program
    {
        public class Solution
        {
            public string RestoreString(string s, int[] indices)
            {
                char[] chars = new char[s.Length];
                for (int i = 0; i < s.Length; i++)
                {
                    chars[indices[i]] = s[i];
                }
                return new string(chars);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
