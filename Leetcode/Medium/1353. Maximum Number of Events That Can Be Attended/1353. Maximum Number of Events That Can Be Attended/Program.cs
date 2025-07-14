namespace _1353._Maximum_Number_of_Events_That_Can_Be_Attended
{
    public class Solution
    {
        public int MaxEvents(int[][] events)
        {
            Array.Sort(events, (a, b) => a[0] - b[0]);
            var pq = new PriorityQueue<int, int>();

            int day = 1, res = 0, i = 0, n = events.Length;

            int lastDay = 0;
            foreach (var e in events)
                lastDay = Math.Max(lastDay, e[1]);

            while (day <= lastDay)
            {
                // Add all events starting today
                while (i < n && events[i][0] == day)
                {
                    pq.Enqueue(events[i][1], events[i][1]); // enqueue endDay
                    i++;
                }

                // Remove all events that already ended
                while (pq.Count > 0 && pq.Peek() < day)
                    pq.Dequeue();

                // Attend the event that ends earliest
                if (pq.Count > 0)
                {
                    pq.Dequeue();
                    res++;
                }

                day++;
            }

            return res;
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
