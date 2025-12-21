#include<iostream>
using namespace std;
class Solution {
public:
    int numberOfWays(string corridor) {
        const int MOD = 1e9 + 7;

        int count = 0;
        int count_total = 0;
        long long result = 0;  

        for (int i = 0; i < corridor.size(); i++) {
            if (corridor[i] == 'S') {
                count++;
                count_total++;
            }

            if (count == 2) {
                count = 0;
                i++;
                int temp = 0;

                while (i < corridor.size() && corridor[i] != 'S') {
                    temp++;
                    i++;
                }

                if (i < corridor.size()) {
                    i--;
                    if (result != 0)
                        result = (result * (temp + 1)) % MOD;
                    else
                        result = (temp + 1) % MOD;
                }
            }
        }

        if (count_total % 2 == 1 || count_total < 2)
            return 0;

        if (count_total == 2)
            return 1;

        return (int)result;
    }
};

int main()
{
    Solution s;
    cout<<s.numberOfWays("SSPPSPS");
    return 0;
}

