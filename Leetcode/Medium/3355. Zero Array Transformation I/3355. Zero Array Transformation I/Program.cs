namespace _3355._Zero_Array_Transformation_I
{
    public class Solution
    {
        // time  : O(n+m)
        // space : O(n)
        /*
         * you have query with start and end 
         * when you reach start add one and when you reach end minus one from the next element 
         * so now you can know every element will be decreament how many times 
         * [4,3,2,1]
         * [0,3]
         * in this case the help will be [1,1,1,1,-1]
         * so to apply it make variable save value of decreament
         * if we add one query [1,2]
         * help will be [1,2,2,1,-1]
         */
        public bool IsZeroArray(int[] nums, int[][] queries)
        {

            int[] help = new int[nums.Length + 1]; // define array which length is bigger than nums

            for (int i = 0; i < queries.Length; i++)
            {
                int start = queries[i][0];
                int end = queries[i][1];

                help[start] += 1;
                help[end + 1] -= 1;

            }
            int minus = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                minus += help[i];
                if (nums[i] > minus)
                {
                    return false;
                }
            }
            return true;

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
