namespace _1936._Add_Minimum_Number_of_Rungs
{
    public class Solution
    {
        public int AddRungs(int[] rungs, int dist)
        {
            int current = 0;
            int count = 0;
            for (int i = 0; i < rungs.Length; i++)
            {
                if (rungs[i] - current <= dist)
                {
                    current = rungs[i];
                    continue;
                }
                else
                {
                    count += (rungs[i] - current - 1) / dist;
                    current = rungs[i];
                }
            }
            return count;
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
