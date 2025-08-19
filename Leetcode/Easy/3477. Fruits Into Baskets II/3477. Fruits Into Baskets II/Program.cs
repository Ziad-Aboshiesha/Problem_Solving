namespace _3477._Fruits_Into_Baskets_II
{
    public class Solution
    {
        public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
        {
            List<int> result = baskets.ToList();
            int ans = fruits.Length;
            for (int i = 0; i < fruits.Length; i++)
            {
                for (int j = 0; j < result.Count; j++)
                {
                    if (fruits[i]<= result[j])
                    {
                        ans--;
                        result.RemoveAt(j);
                        break;
                    }
                }
            }
            return ans;
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
