namespace _1657._Determine_if_Two_Strings_Are_Close
{
    public class Solution
    {
        public bool CloseStrings(string word1, string word2)
        {
            if(word1.Length != word2.Length) return false;
            Dictionary<char, int> dict1 = new Dictionary<char, int>();
            Dictionary<char, int> dict2 = new Dictionary<char, int>();
            for (int i = 0; i < word1.Length; i++)
            {
                dict1.TryAdd(word1[i], 0);
                dict1[word1[i]]++;
                dict2.TryAdd(word2[i], 0);
                dict2[word2[i]]++;
            }
            if(dict1.Count != dict2.Count) return false;
            var list1 = dict1.ToList();
            var list2 = dict2.ToList();
            Dictionary<int , int> dict3 = new Dictionary<int , int>();
            Dictionary<int , int> dict4 = new Dictionary<int , int>();
            for (int i = 0; i < list1.Count; i++)
            {
                if (!dict2.ContainsKey(list1[i].Key)) return false;
                dict3.TryAdd(list1[i].Value, 0);
                dict3[list1[i].Value]++;
                dict4.TryAdd(list2[i].Value, 0);
                dict4[list2[i].Value]++;
            }

            foreach (var item in dict4)
            {
                if (!dict3.ContainsKey(item.Key) || dict3[item.Key] != dict4[item.Key]) return false; 
            }
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
