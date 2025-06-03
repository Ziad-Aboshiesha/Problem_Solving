using System;

namespace _2384._Largest_Palindromic_Number
{
    public class Solution
    {
        public string LargestPalindromic(string num)
        {
            int[] freq = new int[10];
            foreach (char c in num)
            {
                freq[c - '0']++;
            }

            string left = "";
            string right = "";
            string mid = "";

            for (int digit = 9; digit >= 0; digit--)
            {
                while (freq[digit] >= 2)
                {
                    // Avoid leading zero unless it's the only option
                    if (digit == 0 && left.Length == 0) break;

                    left += digit.ToString();
                    right = digit.ToString() + right;
                    freq[digit] -= 2;
                }
            }

            for (int digit = 9; digit >= 0; digit--)
            {
                if (freq[digit] > 0)
                {
                    mid = digit.ToString();
                    break;
                }
            }

            string result = left + mid + right;
            return result == "" ? "0" : result;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.LargestPalindromic("444947137"));
        }
    }
}
