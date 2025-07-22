namespace _1695._Maximum_Erasure_Value
{
    public class Solution
    {
        public int MaximumUniqueSubarray(int[] nums)
        {
            int score = 0, max_score =0, right=0, left = 0;
            HashSet<int> temp = new HashSet<int>();
            for ( right = 0; right < nums.Length; right++)
            {
                if(!temp.Contains(nums[right]))
                {
                    score += nums[right];
                    temp.Add(nums[right]);
                }
                else
                {
                    while(left<right)
                    {
                        score -= nums[left];
                        temp.Remove(nums[left]);
                        if(nums[left] == nums[right])
                        {
                            left++;
                            break;
                        }
                        left++;
                    }
                    score += nums[right];
                    temp.Add(nums[right]);
                }
                max_score = Math.Max(score, max_score); 
            }
            return max_score;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Solution solution = new Solution();
            Console.WriteLine(solution.MaximumUniqueSubarray([5, 2, 1, 2, 5, 2, 1, 2, 5]));
        }
    }
}
