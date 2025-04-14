namespace _3396._Minimum_Number_of_Operations_to_Make
{

    public class Solution
    {

        // time  : O(n*n)
        // space : O(n)
        public int MinimumOperations(int[] nums)
        {
            HashSet<int> sol = nums.ToHashSet();
            if (nums.Length == sol.Count)
            {
                return 0;
            }
            int result = 0;
            while (true)
            {
                if (nums.Length < 3)
                {
                    result++;
                    return result;
                }
                sol = nums.ToHashSet();
                if (nums.Length == sol.Count)
                {
                    return result;
                }
                else
                {
                    nums = nums.Skip(3).ToArray();
                    result++;
                    sol = nums.ToHashSet();
                    if (nums.Length == sol.Count)
                    {
                        return result;
                    }
                }
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
