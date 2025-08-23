namespace _605._Can_Place_Flowers
{
    internal class Program
    {
        public class Solution
        {
            public bool CanPlaceFlowers(int[] flowerbed, int n)
            {
                if (n == 0) return true;
                if(flowerbed.Length == 1)
                {
                    
                }
                for (int i = 1; i < flowerbed.Length - 1; i++)
                {
                    if (flowerbed[i] == 0 && flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
                    {
                        flowerbed[i] = 1;
                        n--;
                    }
                }
                if (flowerbed[0] == 0 && flowerbed[1] == 0) n--;
                if (flowerbed[flowerbed.Length - 1] == 0 && flowerbed[flowerbed.Length - 2] == 0) n--;
                if (n <= 0) return true;
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
