namespace _2108._Find_First_Palindromic_String_in_the_Array
{
    public class Solution
    {

        // time  : O(n * k)
        // space : O(1)
        public string FirstPalindrome(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                string temp = words[i];
                int start = 0;
                int end = temp.Length - 1;
                bool flag = false;
                while (start < end)
                {
                    if (temp[start] != temp[end])
                    {
                        flag = true;
                        break;
                    }



                    start++;
                    end--;
                }
                if (flag == true)
                {
                    flag = false;
                }
                else
                {
                    return temp;
                }
            }
            return "";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
