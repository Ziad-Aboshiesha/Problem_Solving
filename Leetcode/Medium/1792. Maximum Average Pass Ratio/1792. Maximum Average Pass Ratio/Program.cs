namespace _1792._Maximum_Average_Pass_Ratio
{
    internal class Program
    {
        public class Solution
        {
            public double MaxAverageRatio(int[][] classes, int extraStudents)
            {
                int idx = -1;
                double ratio = double.MaxValue;
                double result = 0.0;

                for (int i = 0; i < classes.Length; i++)
                {
                    double curr = (double)classes[i][0] / classes[i][1];
                    if (curr < ratio)
                    {
                        ratio = curr;
                        idx = i;
                    }
                    result += curr;
                }

                result -= (double)classes[idx][0] / classes[idx][1];
                result += (double)(classes[idx][0] + extraStudents) / (classes[idx][1] + extraStudents);

                return result / classes.Length;
            }
        }


        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.MaxAverageRatio([[1, 2], [3, 5], [2, 2]],2));
        }
    }
}
