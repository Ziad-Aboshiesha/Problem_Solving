#include<iostream>
#include<vector>
using namespace std;
class Solution {
public:
    bool kLengthApart(vector<int>& nums, int k) {
        int last_one = -1;
        for(int i = 0 ; i < nums.size(); i ++)
        {
            if(nums[i]==1)
            {
                if(last_one == -1)
                {
                    last_one = i;
                    continue;
                }
                else 
                {
                    if(i - last_one -1>=k)
                    {
                        last_one = i;
                        continue;
                    }else{
                        return false;
                    }
                }
            }
        }
        return true;
    }
};