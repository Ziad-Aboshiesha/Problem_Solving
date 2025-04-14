using System.Collections;

namespace _2206._Divide_Array_Into_Equal_Pairs
{
    public class Solution
    {
        // time  : O(n)
        // space : O(n)
        public bool DivideArray(int[] nums)
        {
            Hashtable h = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                if (h[nums[i]] == null)
                {
                    h[nums[i]] = 1;
                }
                else
                {
                    int i1 = (int)h[nums[i]];
                    i1++;
                    h[nums[i]] = i1;
                }
            }
            foreach (DictionaryEntry item in h)
            {
                if ((int)item.Value % 2 != 0)
                {
                    return false;
                }

            }
            return true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
