namespace _2869._Minimum_Operations_to_Collect_Elements
{
    internal class Program
    {

        public class Solution
        {
            public int MinOperations(IList<int> nums, int k)
            {
                HashSet<int> result = new HashSet<int>();
                int op = 0;
                for(int i = nums.Count - 1; i >= 0;i--)
                {
                    op++;
                   
                    if (nums[i] <= k)
                    {
                        result.Add(nums[i]);
                        
                    }
                    if(result.Count == k )
                    {
                        break;
                    }
                }

                return op;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.MinOperations([ 1, 2],1));
        }
    }
}
