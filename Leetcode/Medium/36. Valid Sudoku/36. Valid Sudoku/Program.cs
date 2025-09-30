namespace _36._Valid_Sudoku
{
    internal class Program
    {
        public class Solution
        {
            public bool IsValidSudoku(char[][] board)
            {
                List<int[]> nums = new List<int[]> { new int[] { 1, 1 },
                                                     new int[] {1,4 },
                                                     new int[] {1,7 },
                                                     new int[] {4,1 },
                                                     new int[] {4,4 },
                                                     new int[] {4,7 },
                                                     new int[] {7,1 },
                                                     new int[] {7,4 },
                                                     new int[] {7,7 },
                };
                List<HashSet<int>> vertical = new List<HashSet<int>>();
                List<HashSet<int>> horizontal= new List<HashSet<int>>();
                List<HashSet<int>> squares = new List<HashSet<int>>();
                for (int i = 0; i < 9; i++)
                {
                    vertical.Add(new HashSet<int>());
                    horizontal.Add(new HashSet<int>());
                    squares.Add(new HashSet<int>());
                }
                for (int i = 0; i < nums.Count; i++)
                {
                    
                    for (int j = nums[i][0] - 1; j < nums[i][0] + 2; j++)
                    {
                        for (int k = nums[i][1] - 1; k < nums[i][1] + 2; k++)
                        {
                            if (board[j][k] != '.')
                            {
                                if (squares[i].Contains(board[j][k]) || horizontal[j].Contains(board[j][k]) 
                                    || vertical[k].Contains(board[j][k]) )
                                {
                                    return false;
                                }else
                                {
                                    squares[i].Add(board[j][k]);
                                    horizontal[j].Add(board[j][k]);
                                    vertical[k].Add(board[j][k]);

                                }
                            }
                        }
                    }
                }
                return true;

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
