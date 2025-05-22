namespace _74._Search_a_2D_Matrix
{
    public class Solution
    {
        // time  : O(log m * n)
        // space : O(1)
        // binary search on row then binary search inside specified row
        public bool SearchMatrix(int[][] matrix, int target)
        {
            
            int start = 0;
            int end = matrix.Length - 1;
            while (start <= end) 
            {
                int mid = (start + end) / 2;
                if (target >= matrix[mid][0] && target <= matrix[mid][matrix[0].Length - 1])
                {
                     return binarySearchOnOneRow(matrix[mid], target);
                }
                else if(target > matrix[mid][matrix[0].Length - 1])
                {
                    start = mid + 1;
                }else if (target < matrix[mid][0])
                {
                    end = mid - 1;
                }
            }
            return false;
        }
        bool binarySearchOnOneRow(int[] matrix, int target) 
        {
            int start = 0;
            int end = matrix.Length - 1;
            while (start <= end) 
            {
                int mid = (start + end) / 2;
                if(target == matrix[mid])
                {
                    return true;
                }else if(target > matrix[mid])
                {
                    start = mid + 1;
                }else if(target < matrix[mid])
                {
                    end = mid - 1;
                }
            }
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.SearchMatrix([[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]],13));
        }
    }
}
