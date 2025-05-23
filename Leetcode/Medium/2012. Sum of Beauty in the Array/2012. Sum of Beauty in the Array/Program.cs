namespace _2012._Sum_of_Beauty_in_the_Array
{
    public class Solution
    {
        // time  : O(n)
        // space : O(n)
        // save biggest element before element i calc its beauty in biggest before variable to compare it 
        // if current less than biggest before so it cant be 2 
        // also need to compare it if it larger than smaller one from the next items but it is saved in array 

        public int SumOfBeauties(int[] nums)
        {
            int sum = 0;
            int biggest_before = nums[0];
            int[] helper_array = new int[nums.Length - 2];
            helper_array[helper_array.Length - 1] = nums[nums.Length -1];
            int temp = nums[nums.Length - 1];


            for (int i = helper_array.Length - 2; i >= 0; i--)
            {
                if (nums[i + 2] < temp)
                {
                    temp = nums[i + 2];
                }
                helper_array[i] = temp;
            }

            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i] > biggest_before && nums[i] < helper_array[ i - 1])
                {
                    sum += 2;
                }
                else if (nums[i] > nums[ i - 1 ] && nums[i] < nums[ i + 1] )
                {
                    sum += 1;
                }
                if (nums[i] > biggest_before)
                {
                    biggest_before = nums[i];
                }
            }
            //for (int i = 0; i < helper_array.Length; i++)
            //{
            //    Console.WriteLine(helper_array[i]);
            //}
            return sum;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine( s.SumOfBeauties([2, 4, 6, 4]));
        }
    }
}
