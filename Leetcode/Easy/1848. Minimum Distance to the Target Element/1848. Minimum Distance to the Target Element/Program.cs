namespace _1848._Minimum_Distance_to_the_Target_Element
{
    public class Solution
    {
        public int GetMinDistance(int[] nums, int target, int start)
        {
            int ans = int.MaxValue;
            int firstfound = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target) 
                {
                    firstfound = i;
                    ans = Math.Abs(i-start);
                    break;
                }

            }
            for (int i = firstfound + 1; i < nums.Length; i++)
            {
                if(Math.Abs(i - start)> ans)
                {
                    break;
                }
                if(nums[i] == target) 
                {
                    ans = Math.Abs(i-start);

                }
            }
            return ans;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
