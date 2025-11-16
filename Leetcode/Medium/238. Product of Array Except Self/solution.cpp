#include<vector>
#include<iostream>
using namespace std;


class Solution {
public:
    vector<int> productExceptSelf(vector<int>& nums) {
        int res =nums[0];
        vector<int> ans (nums.size(),0);
        ans[0]=1;
        for(int i = 1 ; i < nums.size();i++)
        {
            ans[i] = res;
            res *= nums[i];
        }
        res = nums[nums.size()-1];
        for(int i  = nums.size()-2; i >= 0;i--)
        {
            ans[i] = res* ans[i];
            res*= nums[i];
        }


        return ans ;
    }
};


int main ()
{
    Solution s;
    vector<int> nu ={1,2,3,4};
    s.productExceptSelf(nu);
    return 0;
}