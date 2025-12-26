#include<iostream>
#include<vector>
using namespace std;
class Solution {
public:
    int numberOfPoints(vector<vector<int>>& nums) {
        vector<int> slots(100,0);
        int ans=0;
        for(int i = 0 ; i < nums.size(); i++)
        {
            slots[nums[i][0]]++;
            slots[nums[i][1]+1]--;
        }
        int current = 0;
        for(int i = 0 ; i < slots.size(); i++)
        {
            current += slots[i];
            if(current!= 0)ans++;
        }
        return ans;
    }
};

int main()
{
    return 0;
}