namespace _933._Number_of_Recent_Calls
{
    public class RecentCounter
    {
        int count ;
        Queue<int> queue ;
        public RecentCounter()
        {
            count = 0 ;
            queue = new Queue<int>();
        }

        public int Ping(int t)
        {
            count++;
            queue.Enqueue(t);
            while (queue.Count > 0) 
            {
                if(t - queue.Peek() > 3000 )
                {
                    queue.Dequeue();
                    count--;
                }
                else
                {
                    break;
                }
            }
            return count;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            RecentCounter r = new RecentCounter();
            Console.WriteLine(r.Ping(1));
            Console.WriteLine(r.Ping(100));
            Console.WriteLine(r.Ping(3001));
            Console.WriteLine(r.Ping(3002));

        }
    }
}
