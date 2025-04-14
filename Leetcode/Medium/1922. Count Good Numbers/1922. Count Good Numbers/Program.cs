namespace _1922._Count_Good_Numbers
{
    public class Solution
    {

        //Time : O(log(n))
        //Space : O(1)
        const int MOD = 1000000007;

        public int CountGoodNumbers(long n)
        {
            long even = (n + 1) / 2;  // even indices (starting at 0)
            long odd = n / 2;         // odd indices

            long evenPart = ModPow(5, even, MOD);
            long oddPart = ModPow(4, odd, MOD);

            return (int)(evenPart * oddPart % MOD);
        }

        // Binary exponentiation
        private long ModPow(long baseVal, long exp, int mod)
        {
            long result = 1;
            baseVal %= mod;

            while (exp > 0)
            {
                if ((exp & 1) == 1)
                    result = result * baseVal % mod;

                baseVal = baseVal * baseVal % mod;
                exp >>= 1;
            }

            return result;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
