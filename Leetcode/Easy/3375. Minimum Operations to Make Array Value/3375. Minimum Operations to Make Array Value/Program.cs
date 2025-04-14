namespace _3375._Minimum_Operations_to_Make_Array_Value
{
  
    public class Solution
    {

        // time  : O(n)
        // space : O(n)
        public int MinOperations(int[] nums, int k)
        {
            int temp = nums.Min();
            if (temp < k)
            {
                return -1;
            }
            int ans = 0;
            if (temp != k) ans++;
            HashSet<int> numss = new HashSet<int>(nums);
            ans += numss.Count() - 1;
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
