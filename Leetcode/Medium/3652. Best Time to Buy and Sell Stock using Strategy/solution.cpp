#include<iostream>
#include<vector>
using namespace std;

class Solution {
public:
    long long maxProfit(vector<int>& prices, vector<int>& strategy, int k) {
        long long ans =LONG_LONG_MIN;
        long long temp =0;

        for(int i =0; i < prices.size();i++)
        {
            temp +=prices[i] * strategy[i];
        }
        ans = max(temp,ans);
        int start =0;
        int end =k;
        int mid= k/2;

        for(int i =0 ; i < k; i++)
        {
            
            temp -= prices[i] * strategy[i];
            if(i>=mid)
            {
                temp+= prices[i];
            }
        }
        ans = max(temp,ans);
        while(end < prices.size() )
        {
            temp+= prices[start] * strategy[start];
            temp-=prices[mid];
            temp-= prices[end] * strategy[end];
            temp += prices[end];


            ans = max(temp,ans);
            end++;
            start++;
            mid++;
        }
        return ans;
    }
};
int main()
{
    vector<int> one = {4,2,8},two = {-1,0,1};
    Solution s;
    s.maxProfit(one,two,2);
    return 0;
}