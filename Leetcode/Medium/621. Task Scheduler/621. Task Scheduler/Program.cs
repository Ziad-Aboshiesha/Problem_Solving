namespace _621._Task_Scheduler
{
    public class Solution
    {
        public int LeastInterval(char[] tasks, int n)
        {
            int timer = 1;
            Dictionary<char, int[]> counts = new Dictionary<char, int[]>();
            for (int i = 0; i < tasks.Length; i++)
            {
                counts.TryAdd(tasks[i], new int[] { 0, -123 });
                counts[tasks[i]][0]++;
            }
            bool state = true;
            while (counts.Count > 0)
            {
                foreach (var item in counts)
                {
                    if (state == false)
                    {
                        timer += n + 1 - (timer - item.Value[1]);
                    }
                    if (timer - item.Value[1] > n)
                    {
                        state = true;
                        item.Value[1] = timer;
                        timer++;
                        item.Value[0]--;
                        if(item.Value[0] == 0)
                        {
                            counts.Remove(item.Key);
                        }
                    }
                    else
                    {
                        state = false;
                        break;
                    }
                }
            }   



            return timer;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.LeastInterval(['B', 'C', 'D', 'A', 'A', 'A', 'A', 'G'], 1));
        }
    }
}
