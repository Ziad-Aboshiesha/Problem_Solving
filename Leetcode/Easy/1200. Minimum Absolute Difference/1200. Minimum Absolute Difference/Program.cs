namespace _1200._Minimum_Absolute_Difference
{
    public class Solution
    {
        // time  : O(n * log(n))
        // space : O(n)
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            Array.Sort(arr);
            int min = int.MaxValue;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (Math.Abs(arr[i] - arr[i + 1]) < min)
                {
                    min = Math.Abs(arr[i] - arr[i + 1]);
                }
            }
            List<List<int>> result = new List<List<int>>();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (Math.Abs(arr[i] - arr[i + 1]) == min)
                {
                    result.Add(new List<int>() { arr[i], arr[i + 1] });
                }
            }
            return new List<IList<int>>(result);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
