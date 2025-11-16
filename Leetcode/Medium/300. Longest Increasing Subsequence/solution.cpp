#include<vector>
#include<iostream>
using namespace std;


class Solution {
public:
    int lengthOfLIS(vector<int>& nums) {
        vector<int> helper (nums.size());
        helper[0] = 1;
        int longest = 1;
        for(int i =1; i < nums.size(); i++)
        {
            int max = 1;
            for(int j = i-1;j >= 0 ; j--)
            {
                if((nums[i]> nums[j]) && helper[j]+1 > max)
                {
                    max =helper[j]+1;
                }
            }
            helper[i] = max;
            if(max > longest) longest = max;
        }
        return longest;
    }
};
int main()
{


    return 0;
}