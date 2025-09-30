namespace _3000._Maximum_Area_of_Longest_Diagonal_Rectangle
{
    internal class Program
    {
        public class Solution
        {
            public int AreaOfMaxDiagonal(int[][] dimensions)
            {
                double diagonal = 0.0;
                int area = 0;
                for (int i = 0; i < dimensions.Length; i++)
                {
                    double temp = Math.Sqrt(Math.Pow(dimensions[i][0], 2) + Math.Pow(dimensions[i][1], 2));
                    if (temp > diagonal)
                    {
                        diagonal = temp;
                        area = dimensions[i][0] * dimensions[i][1];
                    }
                    else if (temp == diagonal) 
                    {
                        area = Math.Max(area, dimensions[i][0] * dimensions[i][1]);
                    }
                }
                return area;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine( s.AreaOfMaxDiagonal([[2, 6], [5, 1], [3, 10], [8, 4]]));
        }
    }
}
