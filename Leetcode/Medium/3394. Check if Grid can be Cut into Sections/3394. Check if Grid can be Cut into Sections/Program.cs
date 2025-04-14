namespace _3394._Check_if_Grid_can_be_Cut_into_Sections
{
    public class Solution
    {
        // time  : O(n log(n))
        // space : O(n)
        public bool CheckValidCuts(int n, int[][] rectangles)
        {
            int count = 0;
            int[][] sortedx = sortx(rectangles);
            int[][] sortedy = sorty(rectangles);
            // startx   s.y  end.x  e.y
            //    0      2     2     4
            //    0      4     4     5
            //    1      0     5     2
            //    3      2     5     3

            //y lines calced with x values
            //for (int i = 0; i < sortedx.GetLength(0); i++)
            //{
            //    Console.WriteLine(sortedx[i][0] + " " + sortedx[i][1] + " " + sortedx[i][2] + " " + sortedx[i][3]);
            //}
            //for (int i = 0; i < sortedy.GetLength(0); i++)
            //{
            //    Console.WriteLine(sortedy[i][0] + " " + sortedy[i][1] + " " + sortedy[i][2] + " " + sortedy[i][3]);
            //}
            int end = sortedx[0][2];
            for (int i = 0; i < sortedx.GetLength(0) - 1; i++)
            {
                if (sortedx[i + 1][0] >= end)
                {
                    count++;
                }
                if (end < sortedx[i + 1][2])
                {
                    end = sortedx[i + 1][2];
                }
            }
            if (count >= 2) return true;
            count = 0;
            int end2 = sortedy[0][3];
            for (int i = 0; i < sortedy.GetLength(0) - 1; i++)
            {
                if (sortedy[i + 1][1] >= end2)
                {
                    count++;
                }
                if (end2 < sortedy[i + 1][3])
                {
                    end2 = sortedy[i + 1][3];
                }
            }


            if (count >= 2) return true;
            return false;
        }
        public int[][] sortx(int[][] rectangles)
        {
            return rectangles.OrderBy(shape => shape[0])
                    .ThenBy(shape => shape[2])
                    .ToArray();
        }
        public int[][] sorty(int[][] rectangles)
        {
            return rectangles.OrderBy(shape => shape[1])
                    .ThenBy(shape => shape[3])
                    .ToArray();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
