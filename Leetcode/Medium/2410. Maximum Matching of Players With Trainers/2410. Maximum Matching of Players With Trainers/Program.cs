public class Solution {
    public int MatchPlayersAndTrainers(int[] players, int[] trainers)
    {
        Array.Sort(players);
        Array.Sort(trainers);
        int ans = 0;
        int idx = 0;
        for (int i = 0; i < trainers.Length; i++)
        {
            if (players[idx] <= trainers[i])
            {
                ans++;
                idx++;

            }
            if (idx == players.Length)
            {
                break;
            }
        }
        return ans;
        
    }
}