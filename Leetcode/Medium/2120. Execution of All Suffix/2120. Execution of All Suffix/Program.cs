namespace _2120._Execution_of_All_Suffix
{
    public class Solution
    {
        // time  : O(n**n) where is n length of string
        // space : O(m) result
        public int[] ExecuteInstructions(int n, int[] startPos, string s)
        {
            int [] result = new int[s.Length];
            if (n==1) return result;
            for (int i = 0; i < s.Length; i++)
            {
                int count = 0;
                int pos_vertical = startPos[0];
                int pos_horizontal = startPos[1];

                for (global::System.Int32 j = i; j < s.Length; j++)
                {
                    if (s[j] == 'R' && pos_horizontal < n - 1)
                    {
                        pos_horizontal += 1;
                        count++;
                    }
                    else if (s[j] =='L' && pos_horizontal>0)
                    {
                        pos_horizontal -= 1;
                        count++;        
                    }
                    else if (s[j] == 'U' && pos_vertical > 0 )
                    {
                        pos_vertical -= 1;
                        count++;
                    }
                    else if (s[j] == 'D' && pos_vertical < n - 1)
                    {
                        pos_vertical += 1;
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                result[i] = count;
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] answer = s.ExecuteInstructions(3, [0, 1], "RRDDLU");
            for (int i = 0; i < answer.Length; i++)
            {
                Console.WriteLine(answer[i]);
            }
        }
    }
}
