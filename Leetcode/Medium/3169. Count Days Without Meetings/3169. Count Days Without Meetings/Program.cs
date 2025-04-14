namespace _3169._Count_Days_Without_Meetings
{
    public class Solution
    {
        // time  : O(n log(n))
        // space : O(1)
        public void Sort(int[][] arr)
        {
            Array.Sort(arr, (a, b) =>
            {
                if (a[0] != b[0]) return a[0] - b[0];  // Sort by start time
                return a[1] - b[1];                    // If same, sort by end time
            });
        }
        public int CountDays(int days, int[][] meetings)
        {
            Sort(meetings);  // Use optimized sorting
            int count = 0, end = 0;

            foreach (var meeting in meetings)
            {
                if (meeting[1] > end)  // Only consider meetings extending beyond the last recorded end
                {
                    count += Math.Max(0, meeting[1] - Math.Max(meeting[0], end));
                    end = meeting[1];
                }
            }

            return days - count;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
