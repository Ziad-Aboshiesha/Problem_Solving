namespace _1921._Eliminate_Maximum_Number_of_Monsters
{
    public class Solution
    {

        // time  : O(n * log(n))
        // space : O(n)
        public int EliminateMaximum(int[] dist, int[] speed)
        {

            double[] time = new double[dist.Length];
            int killed = 0;
            for (int i = 0; i < time.Length; i++)
            {
                time[i] = (double)dist[i] / speed[i];
            }
            Array.Sort(time);
            for (int i = 0; i < time.Length; i++)
            {
                if (time[i] - i > 0)
                {
                    killed++;
                }
                else
                {
                    break;
                }
            }
            return killed;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
