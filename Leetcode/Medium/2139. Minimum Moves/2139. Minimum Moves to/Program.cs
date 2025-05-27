public class Solution {
    public int MinMoves(int target, int maxDoubles)
    {
        int count_opertions = 0;
        if (target == 1) return count_opertions;
        while (maxDoubles > 0 && target != 1)
        {
            if (target % 2 == 0)
            {
                target /= 2;
                count_opertions++;
                maxDoubles--;
            }
            else
            {
                target--;
                count_opertions++;
            }
        }
        return count_opertions + (target - 1);
    }
}