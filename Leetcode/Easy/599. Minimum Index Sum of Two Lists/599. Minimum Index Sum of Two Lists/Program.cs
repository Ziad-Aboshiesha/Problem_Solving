namespace _599._Minimum_Index_Sum_of_Two_Lists
{
    internal class Program
    {
        public class Solution
        {
            public string[] FindRestaurant(string[] list1, string[] list2)
            {
                int sum = int.MaxValue;
                List<string> answer = new List<string>();
                Dictionary<string , int> dict1 = new Dictionary<string , int>();
                Dictionary<string , int> dict2 = new Dictionary<string , int>();
                for (int i = 0; i < list1.Length; i++)
                {
                    dict1.Add(list1[i], i);
                }
                for (int i = 0; i < list2.Length; i++)
                {
                    dict2.Add(list2[i], i);
                }
                foreach (var item in dict1)
                {
                    if (dict2.ContainsKey(item.Key))
                    {
                        if (dict1[item.Key] + dict2[item.Key] == sum)
                        {
                            answer.Add(item.Key);
                        }
                        else if (dict1[item.Key] + dict2[item.Key] < sum)
                        {
                            answer.Clear();
                            sum = dict1[item.Key] + dict2[item.Key];
                            answer.Add(item.Key);
                        }

                    }

                }
                    return answer.ToArray();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
