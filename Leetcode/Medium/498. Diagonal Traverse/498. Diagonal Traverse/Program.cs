namespace _498._Diagonal_Traverse
{
    internal class Program
    {
        public class Solution
        {
            public int[] FindDiagonalOrder(int[][] mat)
            {
                List<int> result = new List<int>();
                char direction = 'u';
                int row = 0;
                int col = 0;
                while (row < mat.Length && col < mat[0].Length)
                {
                    result.Add(mat[row][col]);
                    if (direction == 'u')
                    {
                        if(row - 1 >=0 && col + 1 < mat[0].Length)
                        {
                            row--;
                            col++;
                            continue;
                        }
                        else
                        {
                            direction = 'd';
                            if(col + 1 < mat[0].Length)
                            {
                                col++;
                            }
                            else if(row + 1 <= mat.Length)
                            {
                                row++;
                            }
                        }
                    }
                    else if (direction == 'd')
                    {
                        if (row + 1 < mat.Length && col - 1 >= 0)
                        {
                            row++;
                            col--;
                            continue;
                        }
                        else
                        {
                            direction = 'u';
                            if (row + 1 < mat.Length)
                            {
                                row++;
                            }
                            else if (col + 1 <= mat[0].Length)
                            {
                                col++;
                            }
                            
                           
                        }
                    }
                }
                
                return result.ToArray();

            }
        }
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] arr = solution.FindDiagonalOrder([[2, 5], [8, 4], [0, -1]]);
            for (int i = 0; i < arr.Length; i++) 
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
