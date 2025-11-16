#include<iostream>
#include<vector>
#include <algorithm> 
using namespace std;
class Solution {
public:
    int minCost(string colors, vector<int>& neededTime) {
        if (colors.size()==1) return 0;
        int left = 0;
        int right = 1;
        int ans = 0 ;
        while(right < colors.size())
        {
            if(colors[right]==colors[left])
            {
                if(neededTime[left]<neededTime[right])
                {
                    ans+= neededTime[left];
                    left = right;
                    right+=1;
                }
                else 
                {
                    ans+= neededTime[right];
                    right+=1;
                }
            }
            else
            {
                left=right;
                right+=1;
            }
        }
        return ans ;

    }
};

int main(){
    Solution s;
    vector<int> nums = {4,8,8,4,4,5,4,2};
    cout<<s.minCost("cddcdcae",nums);
    return 0;
}