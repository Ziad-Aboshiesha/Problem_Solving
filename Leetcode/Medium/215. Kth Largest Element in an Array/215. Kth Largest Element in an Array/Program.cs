namespace _215._Kth_Largest_Element_in_an_Array
{

    public class Solution
    {
        public int FindKthLargest(int[] nums, int k)
        {
            PriorityQueue<int,int> pq = new PriorityQueue<int,int>(k);
            for (int i = 0; i < nums.Length && i < pq.Count; i++) 
            {
                pq.Enqueue(nums[i], nums[i]);
            }
            for (int i = k;i<nums.Length;i++)
            {
                if (nums[i] > pq.Peek())
                {
                    pq.Dequeue();
                    pq.Enqueue(nums[i],nums[i]);
                }
            }
            return pq.Dequeue();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            
        }
    }
}
