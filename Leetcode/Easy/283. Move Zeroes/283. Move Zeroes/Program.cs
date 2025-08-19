namespace _283._Move_Zeroes
{
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int current = 0;
            for (int i = 0; i < nums.Length; i++) 
            {
               if(nums[i] != 0)
               {
                    int temp = nums[current];
                    nums[current] = nums[i];
                    nums[i] = temp;
                    current++;
               }
            }
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
