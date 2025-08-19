namespace _345._Reverse_Vowels_of_a_String
{
    public class Solution
    {
        public string ReverseVowels(string s)
        {
            int right = s.Length - 1;
            int left = 0;
            char[] chars = s.ToCharArray();
            while (left < right)
            {
                if (
                    (s[left] == 'a' || s[left] == 'e' || s[left] == 'i' || s[left] == 'o' || s[left] == 'u'
                    || s[left] == 'U' || s[left] == 'A' || s[left] == 'O' || s[left] == 'I' || s[left] == 'E' )&&
                    (s[right] == 'a' || s[right] == 'e' || s[right] == 'i' || s[right] == 'o' || s[right] == 'u'
                    || s[right] == 'U' || s[right] == 'A' || s[right] == 'O' || s[right] == 'I' || s[right] == 'E')
                    )
                {
                    char temp = s[left];
                    chars[left] = s[right];
                    chars[right] = temp;
                    left++;
                    right--;
                }
                if (!(s[left] == 'a' || s[left] == 'e' || s[left] == 'i' || s[left] == 'o' || s[left] == 'u'
                    || s[left] == 'U' || s[left] == 'A' || s[left] == 'O' || s[left] == 'I' || s[left] == 'E'))
                {
                    left++;
                }
                if (!(s[right] == 'a' || s[right] == 'e' || s[right] == 'i' || s[right] == 'o' || s[right] == 'u'
                    || s[right] == 'U' || s[right] == 'A' || s[right] == 'O' || s[right] == 'I' || s[right] == 'E'))
                {
                    right--;
                }
            }
            s = new string(chars);
            return s;
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
