namespace _1007._Minimum_Domino_Rotations_For_Equal_Row
{
    public class Solution
    {
        // time  : O(n)
        // space : O(1)
        public int MinDominoRotations(int[] tops, int[] bottoms)
        {
            int up = 1;
            int start_up = tops[0];
            int simillar_up = 0;
            int reverse_up = 0;
            bool one = true;
            for (int i = 1; i < tops.Length; i++)
            {
                if (start_up == tops[i] || start_up == bottoms[i])
                {
                    up++;
                    if (tops[i] == bottoms[i])
                    {
                        simillar_up++;
                    }
                    else if (start_up == bottoms[i])
                    {
                        reverse_up++;
                    }
                }
                else
                {
                    one = false;
                    break;
                }
            }
            int bottom = 1;
            int start_bottom = bottoms[0];
            int simillar_bottom = 0;
            int reverse_bottom = 0;
            bool two = true;
            for (int i = 1; i < bottoms.Length; i++)
            {
                if (start_bottom == tops[i] || start_bottom == bottoms[i])
                {
                    bottom++;
                    if (tops[i] == bottoms[i])
                    {
                        simillar_bottom++;
                    }
                    else if (start_bottom == tops[i])
                    {
                        reverse_bottom++;
                    }
                }
                else
                {
                    two = false;
                    break;
                }
            }
            int answera = int.MaxValue;
            int answerb = int.MaxValue;
            if (up == bottoms.Length && one)
            {
                answera = bottoms.Length - simillar_up;
                if (reverse_up < answera / 2.0)
                {
                    answera = reverse_up;
                }
                else
                {
                    answera = answera - reverse_up;
                }
            }
            if (bottom == bottoms.Length && two)
            {
                answerb = bottoms.Length - simillar_bottom;
                if (reverse_bottom < answerb / 2.0)
                {
                    answerb = reverse_bottom;
                }
                else
                {
                    answerb = answerb - reverse_bottom;
                }
            }

            if (answera < int.MaxValue && answera == answerb) return answera;
            if (answera < answerb && answera < int.MaxValue)
            {
                return answera;
            }
            else if (answera > answerb && answerb < int.MaxValue)
            {
                return answerb;
            }
            else
            {
                return -1;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.MinDominoRotations([1, 2, 1, 1, 1, 2, 2, 2], [2, 1, 2, 2, 2, 2, 2, 2]));
        }
    }
}
