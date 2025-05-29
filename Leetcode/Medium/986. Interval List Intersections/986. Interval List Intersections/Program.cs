


public class Solution
{
    // time O(n+m)
    // space O(n+m)
    public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
    {
        if (firstList.Length == 0 || secondList.Length == 0) return [];
        List<List<int>> result = new List<List<int>>();
        int first_pointer = 0;
        int second_pointer = 0;
        while (first_pointer < firstList.Length && second_pointer < secondList.Length)
        {
            if (firstList[first_pointer][0] >= secondList[second_pointer][0]
                && firstList[first_pointer][0] <= secondList[second_pointer][1])
            {
                result.Add([firstList[first_pointer][0], Math.Min(firstList[first_pointer][1], secondList[second_pointer][1])]);

            }
            if (firstList[first_pointer][0] <= secondList[second_pointer][0]
                && firstList[first_pointer][1] >= secondList[second_pointer][0])
            {
                result.Add([secondList[second_pointer][0], Math.Min(firstList[first_pointer][1], secondList[second_pointer][1])]);
            }
            if (firstList[first_pointer][1] > secondList[second_pointer][1])
            {
                second_pointer++;
            }
            else if (firstList[first_pointer][1] < secondList[second_pointer][1])
            {
                first_pointer++;
            }
            else
            {
                first_pointer++;
                second_pointer++;
            }
        }

        return result.Select(innerList => innerList.ToArray()).ToArray();

    }
}