Solution s = new Solution();
System.Console.WriteLine(   s.ClearStars("abc*de*fgh*"));
string ss = "safasdf";
public class Solution
{
    public string ClearStars(string s)
    {
        List<char> arr = s.ToList();
        HashSet<int> dl = new();
        PriorityQueue<int, (int p, int idx)> pq = new();
        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] != '*')
            {
                pq.Enqueue(i, ((int)arr[i], -i));
            }
            else
            {
                dl.Add(i);
                dl.Add(pq.Dequeue());


            }
        }
        for (int i = 0; i < arr.Count; i++)
        {
            if (dl.Contains(i))
            {

                arr[i] = '\0';
            }
        }
        string  sss = new string(arr.ToArray());
        return sss.Replace("\0", "");

    }
}