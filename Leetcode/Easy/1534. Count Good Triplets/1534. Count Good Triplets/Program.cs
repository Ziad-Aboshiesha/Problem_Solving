namespace _1534._Count_Good_Triplets
{
    public class Solution
    {
        // time  : O(n**3)
        // space : O(1)
        public int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (global::System.Int32 j = i + 1; j < arr.Length; j++)
                {
                    for (global::System.Int32 k = j + 1; k < arr.Length; k++)
                    {
                        if (Math.Abs(arr[i] - arr[j]) <= a && Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                        {
                            count++;
                        }
                    }
                }
            }


            return count;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
