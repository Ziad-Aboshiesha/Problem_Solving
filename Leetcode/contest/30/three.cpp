#include<iostream>
#include<vector>
#include <algorithm>
#include <unordered_set>
#include <unordered_map>

using namespace std;

class Solution {
public:
    int minMirrorPairDistance(vector<int>& nums) {
        int ans = INT_MAX;
        unordered_map <int,int>x ;
        for(int i = 0  ; i< nums.size(); i++)
        {
            if(x.find(nums[i])!=x.end())
            {
                ans = min(ans, abs(i- x[nums[i]]));

            }
                int copy = nums[i];
                int temp = 0;
                while(copy!= 0)
                {
                    temp=temp*10 +  copy%10;
                    copy = copy /10;
                }
                if(x.find(temp)==x.end())
                {
                    x.insert({temp,i});
                }else
                {
                    x[temp]=i;
                }
        }


        if(ans==INT_MAX) return -1;
        return ans;
    }
};

int main()
{
    Solution s ;
    vector<int> ss = {12,21,45,33,54};
    cout<<s.minMirrorPairDistance(ss);
    return 0;
}