#include<iostream>
#include<vector>
using namespace std;
class Solution {
public:
    long long getDescentPeriods(vector<int>& prices) {
        long long ans = prices.size();
        int count = 1;
        for(int i =0 ; i < prices.size()-1;i++)
        {
            if(prices[i] - prices[i+1] == 1)
            {
                count++;
            }
            else
            {
                long temp = (count * ( count - 1) ) /2 ;
                ans += temp;
                count =1;
            }
        }
        if(count != 1)
        {
            long temp = (count * ( count - 1) ) /2 ;
            ans += temp;
        }

        return ans;
    }
};
int main()
{

}