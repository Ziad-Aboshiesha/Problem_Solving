namespace _1657._Determine_if_Two_Strings_Are_Close
{
    public class Solution
    {
        public bool CloseStrings(string word1, string word2)
        {
            if(word1.Length != word2.Length) return false;
            char[] chars = word1.ToCharArray();
            HashSet<char> result = chars.ToHashSet();
            char[] chars2 = word2.ToCharArray();
            HashSet<char> result2 = chars2.ToHashSet();
            foreach(char c in result)
            {
                if(!result2.Contains(c)) return false;
                result2.Remove(c);
                result.Remove(c);

            }
            if(result2.Count != 0 || result.Count!=0) return false;
            return true;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Solution s = new Solution();
            Console.WriteLine(s.CloseStrings("aabbss", "cabbba"));
        }
    }
}
