namespace _1306._Jump_Game_III
{
    internal class Program
    {
        public class Solution
        {
            public bool CanReach(int[] arr, int start)
            {
                if (arr[start] == 0) return true;
                HashSet<int> visited = new HashSet<int>();
                Queue<int> queue = new Queue<int>();
                visited.Add(start);
                queue.Enqueue(start);
                while (queue.Count > 0) 
                {
                    int current = queue.Dequeue();
                    int sum = arr[current] + current;
                    int diff =  current - arr[current] ;

                    if (sum < arr.Length && !visited.Contains(sum))
                    {
                        if (arr[sum]== 0 ) return true;
                        queue.Enqueue(sum);
                        visited.Add(sum);
                    }
                    if (diff > 0 && !visited.Contains(diff))
                    {
                        if (arr[diff] == 0) return true;
                        queue.Enqueue(diff);
                        visited.Add(diff);
                    }
                }
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
