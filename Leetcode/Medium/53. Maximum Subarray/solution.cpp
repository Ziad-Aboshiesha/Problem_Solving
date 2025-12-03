#include<iostream>
#include<vector>
using namespace std;
class Solution {
public:
    int maxSubArray(vector<int>& nums) {
        int left = 0 ;
        int right = 0;
        int sum = nums[0];
        int temp_sum = nums[0];
        for(right = 1 ;right<nums.size();right++)
        {
            while (temp_sum<0&& left<=right)
            {
                temp_sum-= nums[left];
                left++;
            }
            temp_sum+=nums[right];
            if(temp_sum>sum) sum = temp_sum;
        }
        return sum;
    }
};
int main()
{
    return 0;
}