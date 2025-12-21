
#include<iostream>
#include<vector>
using namespace std;
class Solution {
public:
    int countPartitions(vector<int>& nums) {
        int sum=0;
        for(int i = 0 ;i<nums.size();i++)
        {
            sum+= nums[i];
        }
        int sumleft= nums[0];
        int ans = 0;
        for(int i = 1; i < nums.size();i++)
        {
            int sumright = sum-sumleft;
            if((sumright - sumleft)%2==0)
            {
                ans++;
            }
            sumleft++;
        }
        return ans;
    }
};
int main()
{

}