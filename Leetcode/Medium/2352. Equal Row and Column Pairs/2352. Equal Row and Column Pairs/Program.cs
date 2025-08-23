namespace _2352._Equal_Row_and_Column_Pairs
{

    public class Solution
    {
        public int EqualPairs(int[][] grid)
        {
            int n = grid.Length;
            int equalPairs = 0;

            // Store frequency of each row as a string for easy comparison.
            // A dictionary is used for efficient lookup.
            Dictionary<string, int> rowCounts = new Dictionary<string, int>();

            // Step 1: Count the frequency of each row.
            for (int i = 0; i < n; i++)
            {
                // Convert the row array to a string to use as a dictionary key.
                string rowString = string.Join(",", grid[i]);
                if (rowCounts.ContainsKey(rowString))
                {
                    rowCounts[rowString]++;
                }
                else
                {
                    rowCounts[rowString] = 1;
                }
            }

            // Step 2: Iterate through each column and check for matches.
            for (int j = 0; j < n; j++)
            {
                // Build the current column as a list.
                List<int> currentColumn = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    currentColumn.Add(grid[i][j]);
                }

                // Convert the column list to a string for comparison with row strings.
                string columnString = string.Join(",", currentColumn);

                // If the column string exists in the rowCounts dictionary, add its frequency to the total.
                if (rowCounts.ContainsKey(columnString))
                {
                    equalPairs += rowCounts[columnString];
                }
            }

            return equalPairs;
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
