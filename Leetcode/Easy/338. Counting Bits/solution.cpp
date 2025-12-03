#include<iostream>
#include<vector>
#include <cmath>
using namespace std;
class Solution {
public:
    vector<int> countBits(int n) {
        vector<int> ans (n+1);
        ans[0]=0;
        if(n==0) return ans;
        int power = 0;
        for(int i = 1;i <= n ; i ++)
        {
            if(i == pow(2,power))
            {
                ans[i]=1;
                power++;

            }else
            {
                int temp = power-1 ;
                int answer = 1 + ans[i- pow(2,temp)];
                ans[i]=answer;
            }
        }   
        return ans;
    }
};
int main()
{
    Solution s ;
    vector<int> ans = s.countBits(5);
    return 0;
}