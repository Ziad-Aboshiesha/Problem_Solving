namespace _1865._Finding_Pairs_With_a_Certain_Sum
{
    public class FindSumPairs
    {
        private int[] nums1;
        private int[] nums2;
        private Dictionary<int, int> freq2;

        public FindSumPairs(int[] nums1, int[] nums2)
        {
            this.nums1 = nums1;
            this.nums2 = nums2;

            // Initialize frequency map for nums2 only
            freq2 = new Dictionary<int, int>();
            foreach (int num in nums2)
            {
                if (!freq2.ContainsKey(num)) freq2[num] = 0;
                freq2[num]++;
            }
        }

        public void Add(int index, int val)
        {
            int oldVal = nums2[index];
            int newVal = oldVal + val;

            // Update nums2
            nums2[index] = newVal;

            // Update frequency map
            freq2[oldVal]--;
            if (freq2[oldVal] == 0) freq2.Remove(oldVal);

            if (!freq2.ContainsKey(newVal)) freq2[newVal] = 0;
            freq2[newVal]++;
        }

        public int Count(int tot)
        {
            int count = 0;

            // For each a in nums1, check if tot - a exists in nums2 frequency map
            foreach (int a in nums1)
            {
                int b = tot - a;
                if (freq2.ContainsKey(b))
                {
                    count += freq2[b];
                }
            }

            return count;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
