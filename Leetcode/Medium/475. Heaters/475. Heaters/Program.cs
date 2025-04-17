namespace _475._Heaters
{
    public class Solution
    {

        // time  : O(n log m )
        // space : O(1)
        public int FindRadius(int[] houses, int[] heaters)
        {
            Array.Sort(heaters);
            int maxRadius = 0;

            foreach (int house in houses)
            {
                int closestDist = FindClosestHeaterDistance(house, heaters);
                maxRadius = Math.Max(maxRadius, closestDist);
            }

            return maxRadius;
        }

        private int FindClosestHeaterDistance(int house, int[] heaters)
        {
            int left = 0, right = heaters.Length - 1;

            
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (heaters[mid] == house)
                {
                    return 0;
                }
                else if (heaters[mid] < house)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

         
            int distLeft = (right >= 0) ? Math.Abs(house - heaters[right]) : int.MaxValue;
            int distRight = (left < heaters.Length) ? Math.Abs(house - heaters[left]) : int.MaxValue;

            return Math.Min(distLeft, distRight);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.FindRadius([1, 1, 1, 1, 1, 1, 999, 999, 999, 999, 999],[499, 500, 501]));
        }
    }
}
