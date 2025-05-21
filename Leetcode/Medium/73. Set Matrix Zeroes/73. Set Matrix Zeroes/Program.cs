namespace _73._Set_Matrix_Zeroes
{
    public class Solution
    {
        // time  : O(m*n)
        // space : O(m+n)
        public void SetZeroes(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            HashSet<int> rows = new HashSet<int>();
            HashSet<int> columns = new HashSet<int>();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        rows.Add(i);
                        columns.Add(j);
                    }
                }
            }
            foreach (var item in columns)
            {
                for (int i = 0; i < m; i++)
                {
                    matrix[i][item] = 0; 
                }
            }
            //Console.WriteLine("--");
            foreach (var item in rows)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[item][j] = 0;
                }
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.SetZeroes([[0, 1, 2, 0], [3, 4, 5, 2], [1, 3, 1, 5]]);
        }
    }
}
