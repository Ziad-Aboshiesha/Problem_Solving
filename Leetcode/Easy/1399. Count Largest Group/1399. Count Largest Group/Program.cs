using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace _1399._max_Largest_Group
{

    public class Solution
    {
        // time  : O(n*m)
        // space : O(n)
        public int CountLargestGroup(int n)
        {
            int max = 1;
            Hashtable ht = new Hashtable();
            for (int i = 1; i <=n; i++)
            {
                int sum = 0;
                int temp = i;
                while (temp > 0)
                {
                    sum += temp % 10;

                    temp = temp / 10;
                }
                if (ht[sum] == null)
                {
                    ht[sum] = 1;
                }
                else
                {
                    ht[sum] = (int)ht[sum] + 1;
                    if ((int)ht[sum]>max) max = (int) ht[sum];
                }
            }
            int count = 0;
            foreach (int item in ht.Keys)
            {
                if ((int)ht[item] == max) count++; 
            }
            return count;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.CountLargestGroup(10);
        }
    }
}
