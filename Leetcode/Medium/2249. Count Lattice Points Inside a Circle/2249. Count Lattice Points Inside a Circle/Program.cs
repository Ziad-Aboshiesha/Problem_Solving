public class Solution {
    public int CountLatticePoints(int[][] circles)
    {
        HashSet<string> res = new HashSet<string>();
        for (int i = 0; i < circles.Length; i++)
        {
            int x = circles[i][0];
            int y = circles[i][1];
            int r = circles[i][2];

            for (int j = x - r; j <= x + r; j++)
            {
                for (int k = y - r; k <= y + r; k++)
                {
                    if ((x - j) * (x - j) + (y - k) * (y - k) <= r * r)
                    {
                        res.Add($"{j},{k}");
                    }
                }
            }
        }
        return res.Count;
    }
}