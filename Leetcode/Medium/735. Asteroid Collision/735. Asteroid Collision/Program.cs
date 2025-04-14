namespace _735._Asteroid_Collision
{

    public class Solution
    {
        // time  : O(n)
        // space : O(n)
        public int[] AsteroidCollision(int[] asteroids)
        {
            if (asteroids.Length <= 1) return asteroids;
            int i = 0;
            Stack<int> stack = new Stack<int>();
            while (i < asteroids.Length)
            {
                // stack is empty , stack and element in same way , stack is left and element is right
                //all of these condition dont have collision
                if (stack.Count == 0 || (stack.Peek() * asteroids[i]) > 0 || (stack.Peek() < 0 && asteroids[i] > 0))
                {
                    stack.Push(asteroids[i]);
                    i++;
                    continue;
                }
                else // collision done , use absolute of numbers
                {
                    if (Math.Abs(stack.Peek()) > Math.Abs(asteroids[i]))
                    {
                        i++;
                        continue;
                    }
                    else if (-1 * stack.Peek() == asteroids[i])
                    {
                        stack.Pop();
                        i++;
                        continue;
                    }
                    else
                    {
                        stack.Pop();
                        continue;
                    }
                }
            }
            return stack.Reverse().ToArray();

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
