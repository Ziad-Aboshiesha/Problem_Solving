#include<iostream>
#include<vector>
#include <unordered_set>
using namespace std;
class Solution {
public:
    int findFinalValue(vector<int>& nums, int original) {
        unordered_set<int> nums_set;
        for(int i = 0 ; i < nums.size();i++)
        {
            if(nums_set.find(nums[i])== nums_set.end())
            {
                nums_set.insert(nums[i]);
            }
        }
        while(nums_set.find(original) != nums_set.end())
        {
            original = original *2;
        }
        return original;
    }
};
int main()
{
    return 0;
}