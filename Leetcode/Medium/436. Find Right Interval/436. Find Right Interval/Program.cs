using System.Collections;

namespace _436._Find_Right_Interval
{
    public class Solution
    {
        // * time : o(n log n )
        // * space : o(n)
        public int[] FindRightInterval(int[][] intervals)
        {
            if (intervals.Length == 1)
            {
                if (intervals[0][0] == intervals[0][1])
                {
                    return new int[1] { 0 };

                }
                else
                {
                    return new int[1] { -1 };

                }
            }

            int[] answers = new int[intervals.Length];

            Hashtable hashs = new Hashtable(StructuralComparisons.StructuralEqualityComparer);
            for (int i = 0; i < intervals.Length; i++)
            {
                hashs[intervals[i]] = i;
            }
            Array.Sort(intervals, (a, b) =>
            {
                if (a[0] != b[0])
                    return a[0].CompareTo(b[0]);
                else
                    return a[1].CompareTo(b[1]);
            });
            for (int i = 0; i < intervals.Length; i++)
            {
                int start = i + 1;
                int end = intervals.Length - 1;
                int mid = (start + end) / 2;
                int current = (int)hashs[intervals[i]];

                if (intervals[i][0] == intervals[i][1])
                {
                    answers[current] = current;
                    continue;
                }
                while (start <= end)
                {
                    mid = (start + end) / 2;
                    if (intervals[mid][0] >= intervals[i][1])
                    {
                        if (intervals[mid - 1][0] >= intervals[i][1])
                        {
                            end = mid - 1;

                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                if (mid == intervals.Length - 1 && intervals[mid][0] < intervals[i][1])
                {
                    answers[current] = -1;

                }
                else
                {
                    answers[current] = (int)hashs[intervals[mid]];
                }

            }

            answers[(int)hashs[intervals[intervals.Length - 1]]] = -1;
            return answers;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
