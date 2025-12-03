#include<iostream>
#include<vector>
using namespace std;

class Solution {
public:
    int minEatingSpeed(vector<int>& piles, int h) {
        int start =1;
        int ans = INT_MAX;
        int end=0;
        for(int i= 0; i < piles.size();i++)
        {
            if(end<piles[i]) end = piles[i];
        }
        while(start<=end)
        {
            int mid = (start+end) /2;
            int temp = 0;
            for(int i = 0 ; i < piles.size();i++)
            {
                int division = piles[i]/mid;
                temp+=division;
                if(piles[i]%mid!=0) temp+=1;
                if(temp>h) break;
            }
            if(temp<=h ) 
            {
                ans = min(ans,mid);
                end= mid-1;
            }else
            {
                start = mid+1;
            }
        }
        return ans;
    }
};
int main()
{
    vector<int> test = {3,6,7,11};
    Solution s ;
    cout<<s.minEatingSpeed(test,8);
    return 0;
}