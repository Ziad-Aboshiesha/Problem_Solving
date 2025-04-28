namespace _48._Rotate_Image
{
    public class Solution
    {
        public void Rotate(int[][] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (global::System.Int32 j = i; j < matrix.GetLength(0); j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (global::System.Int32 j = 0; j < matrix.GetLength(0) / 2 ; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[i][matrix.GetLength(0) - 1 - j];
                    matrix[i][matrix.GetLength(0) - 1 - j] = temp;
                }
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[][] matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
            s.Rotate(matrix);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (global::System.Int32 j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
