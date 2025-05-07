namespace _11._Container_With_Most_Water
{
    public class Solution
    {
        // time  : O(n)
        // space : O(1)
        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int area = 0;

            while (left < right) 
            {
                int temp = (right - left) * Math.Min(height[left], height[right]);
                if(temp > area) {area = temp;}
                if (height[left] > height[right])
                {
                    right--;
                }
                else 
                {
                    left++;
                }
            }


            return area;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
