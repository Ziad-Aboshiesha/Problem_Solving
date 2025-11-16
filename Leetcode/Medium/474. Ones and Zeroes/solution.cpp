#include<iostream>
#include<vector>
using namespace std;
class Solution {
public:
    int findMaxForm(vector<string>& strs, int m, int n) {
        vector<vector<int>> dp(m + 1, vector<int>(n + 1, 0));

        for (int i = 0; i < strs.size(); i++) {
            int zeros = 0, ones = 0;

            
            for (char c : strs[i]) {
                if (c == '0') zeros++;
                else ones++;
            }

            
            for (int zero = m; zero >= zeros; zero--) {
                for (int one = n; one >= ones; one--) {
                    dp[zero][one] = max(dp[zero][one], dp[zero - zeros][one - ones] + 1);
                }
            }
        }

        return dp[m][n]; 
    }
};
int main()
{
    Solution s ;
    vector<string> arr = {"10","0001","111100","0","1"};
    cout<<s.findMaxForm(arr,5,3);
    return 0;
}