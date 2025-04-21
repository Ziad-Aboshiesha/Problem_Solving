namespace _2145._Count_the_Hidden_Sequences
{
    public class Solution
    {
        public int NumberOfArrays(int[] differences, int lower, int upper)
        {
            long m = upper - lower + 1;
            long answer = 0;
            long[] arr = new long[differences.Length + 1];
            long min = differences[0], max = differences[0];
            arr[0] = differences[0];
            for (int i = 0; i < differences.Length; i++)
            {
                arr[i + 1] = arr[i] + differences[i];
                if (arr[i + 1] > max) max = arr[i + 1];
                if (arr[i + 1] < min) min = arr[i + 1];

            }
            if (m > (max - min))
                answer = m - (max - min);

            return (int)answer;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

        }
    }
}
