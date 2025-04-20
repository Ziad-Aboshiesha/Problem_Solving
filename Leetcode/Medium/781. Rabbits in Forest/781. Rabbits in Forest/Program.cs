namespace _781._Rabbits_in_Forest
{

    public class Solution
    {
        // time  : O(n)
        // space : O(n)
        public int NumRabbits(int[] answers)
        {
            Dictionary<int, int> count_occurance = new Dictionary<int, int>();
            int count = 0 ;
            for (int i = 0; i < answers.Length; i++)
            {
                if (count_occurance.ContainsKey(answers[i]))
                {
                    count_occurance[answers[i]]++;
                }
                else
                {
                    count_occurance[answers[i]] = 1;
                }
            }
            foreach (int item in count_occurance.Keys)
            {
                if (count_occurance[item] == 1)
                {
                    count += item + 1;
                } 
                else
                {
                    int temp = (int)Math.Ceiling((double)count_occurance[item] / (item + 1));
                    count += (item +  1) * temp;
                }
            }

            return count ;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.NumRabbits([10,10,10]));
        }
    }
}
