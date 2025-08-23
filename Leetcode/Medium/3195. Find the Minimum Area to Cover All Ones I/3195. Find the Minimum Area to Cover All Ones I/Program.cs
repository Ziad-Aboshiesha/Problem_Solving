namespace _3195._Find_the_Minimum_Area_to_Cover_All_Ones_I
{
    internal class Program
    {
        public class Solution
        {
            public int MinimumArea(int[][] grid)
            {
                int min_up = int.MaxValue;
                int min_left = int.MaxValue;
                int most_down = int.MinValue;
                int most_right = int.MinValue;
                for (int i = 0; i < grid.Length; i++)   // rows
                {
                    for (int j = 0; j < grid[i].Length; j++)   // columns of row i
                    {
                        if (grid[i][j] == 1)
                        {
                            min_up = Math.Min(min_up, i);
                            most_down = Math.Max(most_down, i);
                            min_left = Math.Min(min_left, j);
                            most_right = Math.Max(most_right, j);
                        }
                    }
                }
                return ((most_right - min_left) + 1) * (most_down - min_up + 1);
            }
        }
        static void Main(string[] args)
        {
            Solution s  = new Solution();
            Console.WriteLine(s.MinimumArea([[0, 1, 0], [1, 0, 1]]));
        }
    }
}
