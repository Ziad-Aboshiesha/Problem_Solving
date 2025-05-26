Solution s = new Solution();
int[][] new_matrix  = s.Transpose([[1,2,3],[4,5,6]]);
for (int i = 0; i < new_matrix.Length; i++)
{
    for (int j = 0; j < new_matrix[0].Length; j++)
    {
        System.Console.WriteLine(new_matrix[i][j]);
        
    }    
}
public class Solution
{
    public int[][] Transpose(int[][] matrix)
    {
        int[][] new_matrix = new int[matrix[0].Length][];
        for (int i = 0; i < matrix[0].Length; i++)
        {
            new_matrix[i] = new int[matrix.Length];
        }
        for (int i = 0; i < matrix.Length; i++)
            {
                
                for (int j = 0; j < matrix[0].Length; j++)
                {

                    new_matrix[j][i] = matrix[i][j];

                }
            }
        return new_matrix;

    }
}