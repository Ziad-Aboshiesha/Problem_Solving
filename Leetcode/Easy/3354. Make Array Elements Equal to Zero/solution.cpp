#include<iostream>
#include <vector>
using namespace std;

class Solution {
public:
    int countValidSelections(vector<int>& nums) {
        int count=0, sum =0, left = 0 ;
        for (int num : nums) sum+=num;
        for(int i = 0; i < nums.size ();i++)
        {
            left+= nums[i];
            sum -= nums[i];
            if(nums[i]==0)
            {
                if(left == sum) count +=2;
                if(abs(left-sum )== 1) count +=1;

            }
        
        }
        return count;
    }
};

int main()
{
    Solution s ;
    vector<int>sum = {1,0,2,0,3};
    cout<< s.countValidSelections(sum);
}