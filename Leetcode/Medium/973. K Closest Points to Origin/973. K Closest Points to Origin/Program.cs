namespace _973._K_Closest_Points_to_Origin
{
    internal class Program
    {
        public class Solution
        {
            public int[][] KClosest(int[][] points, int k)
            {
                int[][] result = new int[k][];
                PriorityQueue<int,double> pq = new PriorityQueue<int,double>();
                for (int i = 0; i < points.Length; i++)
                {
                    double temp = Math.Sqrt(Math.Pow(Math.Abs(points[i][0]), 2) + Math.Pow(Math.Abs(points[i][1]), 2));
                    pq.Enqueue(i,temp);
                }
                int j = 0;
                while(j<k)
                {
                    int z = pq.Dequeue();
                    result[j] = points[z];
                    j++;
                }

                return result;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
