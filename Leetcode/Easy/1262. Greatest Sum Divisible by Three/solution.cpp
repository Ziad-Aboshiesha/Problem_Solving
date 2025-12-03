#include<iostream>
#include<vector>
using namespace std;

class Solution {
public:
    int maxSumDivThree(vector<int>& nums) {
        int total_sum=0;
        int smallest_rem_1=INT_MAX;
        int smallest_rem_2=INT_MAX;
        for(int i = 0 ; i < nums.size(); i++)
        {
            total_sum+= nums[i];
            if(nums[i]% 3 ==1 && nums[i]<smallest_rem_1) smallest_rem_1 = nums[i];
            if(nums[i]% 3 ==2 && nums[i]<smallest_rem_2) smallest_rem_2 = nums[i];

        }
         
        if(total_sum%3==1) return total_sum - smallest_rem_1;
        if(total_sum%3==2) return total_sum - smallest_rem_2;
return total_sum;

    }
};

int main()
{
    return 0;
}