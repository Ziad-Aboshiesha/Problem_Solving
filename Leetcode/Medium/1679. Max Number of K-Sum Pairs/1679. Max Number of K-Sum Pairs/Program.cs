namespace _1679._Max_Number_of_K_Sum_Pairs
{
    public class Solution
    {
        public int MaxOperations(int[] nums, int k)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] >= k) continue;
                result.TryAdd(nums[i], 0);
                result[nums[i]]++;
            }
            int count = 0;
            foreach(int i in result.Keys)
            {
                int temp = k - i;
                if(result.ContainsKey(temp))
                {
                    if(temp ==  i )
                    {
                        count += result[temp] / 2;
                        result.Remove(temp);
                    }
                    else 
                    {
                        
                        count+= Math.Min(result[temp], result[i]);
                        result.Remove(temp) ;
                        result.Remove(i);

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
           Solution s = new Solution();
            Console.WriteLine(s.MaxOperations([4, 4, 1, 3, 1, 3, 2, 2, 5, 5, 1, 5, 2, 1, 2, 3, 5, 4],2));
        }
    }
}
