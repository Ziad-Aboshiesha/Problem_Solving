namespace _120._Triangle
{
    public class Solution
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            int main = triangle[0][0];
            for (int i = triangle.Count -2; i >0 ; i--)
            {
                for (int j = 0; j < triangle[i].Count; j++)
                {
                    triangle[i][j] = Math.Min(triangle[i][j] + triangle[i + 1][j], triangle[i][j] + triangle[i + 1][j + 1]);
                }
            }

            if (triangle.Count > 1)
            {
                main = Math.Min(main + triangle[1][0], main + triangle[1][1]);
            }
            

            return main;
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
