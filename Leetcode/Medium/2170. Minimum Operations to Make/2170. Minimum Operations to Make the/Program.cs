Solution s = new();
System.Console.WriteLine(s.MinimumOperations([2,2,3,4,2,2,3,4,2,2,3,2,2,1,3,5,2]));
public class Solution
{
    public int MinimumOperations(int[] nums)
    {
        if(nums.Length <= 1) return 0;
        int count = 0;
        Dictionary<int, int> odd = new Dictionary<int, int>();
        Dictionary<int, int> even = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (i % 2 == 0)
            {
                even.TryAdd(nums[i], 0);
                even[nums[i]]++;
            }
            else
            {
                odd.TryAdd(nums[i], 0);
                odd[nums[i]]++;
            }
        }
        int big_odd = -1;
        int count_odd = -1;
        int big_even = -1;
        int count_even = -1;
        int second_big_odd = 0;
        int second_count_odd = 0;
        int second_big_even = 0;
        int second_count_even = 0;
        foreach (var item in odd)
        {
            if (item.Value > count_odd)
            {
                second_big_odd = big_odd;
                second_count_odd = count_odd;

                big_odd = item.Key;
                count_odd = item.Value;
            }
            else if (item.Value > second_count_odd && item.Key != big_odd)
            {
                second_big_odd = item.Key;
                second_count_odd = item.Value;
            }
        }

        foreach (var item in even)
        {
            if (item.Value > count_even)
            {
                second_big_even = big_even;
                second_count_even = count_even;

                big_even = item.Key;
                count_even = item.Value;
            }
            else if (item.Value > second_count_even && item.Key != big_even)
            {
                second_big_even = item.Key;
                second_count_even = item.Value;
            }
        }
        if (big_even == big_odd)
        {
            if (second_big_even == -1 && second_big_odd == -1)
            {
                count += nums.Length / 2;
            }
            else
            {
                int temp1 = 0, temp2 = 0;
                temp1 += (int)Math.Ceiling(nums.Length / 2.0) - second_count_even;
                temp1 += (nums.Length / 2) - count_odd;


                temp2 += (int)Math.Ceiling(nums.Length / 2.0) - count_even;
                temp2 += (nums.Length / 2) - second_count_odd;
                count = Math.Min(temp1, temp2);
            }
        }
        else
        {
            count += (int)Math.Ceiling(nums.Length / 2.0) - count_even;
            count += (nums.Length / 2) - count_odd;
        }

        return count;
    }
}