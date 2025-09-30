namespace _35._Search_Insert_Position
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int idx = 0;
            int start = 0, end = nums.Length-1,mid;
            while (start <= end) 
            {
                mid = (start+end)/2;
                if(nums[mid] == target)
                {
                    idx = mid;
                    break;
                }
                else if (nums[mid] >  target)
                {
                    end = mid - 1;
                    idx = mid ;
                    continue;
                }
                else
                {
                    start = mid + 1;
                    idx = mid + 1;  
                    continue ;
                }
            }
            if (idx < 0) return 0;
            return idx;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.SearchInsert([1, 3],2));
        }
    }
}
