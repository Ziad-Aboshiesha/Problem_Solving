#include<iostream>
using namespace std;
#include<vector>
class Solution {
public:
    bool increasingTriplet(vector<int>& nums) {
        int first = nums[0];
        int second = INT_MAX;
        for(int i = 1 ; i < nums.size(); i++)
        {
            if(nums[i] > second) return true;
            if(nums[i] > first && nums[i] < second)
            {
                second = nums[i];
            }
            if(nums[i] < first )
            {
                first = nums[i];
            }
        }
        return false;
    }
};
int main()
{
    return 0;
}