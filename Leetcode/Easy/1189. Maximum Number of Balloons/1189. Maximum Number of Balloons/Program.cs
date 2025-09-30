namespace _1189._Maximum_Number_of_Balloons
{
    internal class Program
    {
        public class Solution
        {
            public int MaxNumberOfBalloons(string text)
            {
                int count = int.MaxValue;
                Dictionary<char,int> map = new Dictionary<char,int>();
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i]=='b' || text[i] == 'n' || text[i] == 'o' || text[i] == 'l' || text[i] == 'a' )
                    {
                        map.TryAdd(text[i], 0);
                        map[text[i]]++;
                    }

                }
                if(map.Count != 5) return 0;
                foreach (var item in map)
                {
                    int temp = item.Value;
                    if(item.Key =='l' || item.Key=='o')
                    {
                        temp /= 2;
                    }
                    count = Math.Min(count, temp);
                }


                return count;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
