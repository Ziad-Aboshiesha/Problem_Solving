#include<iostream>
#include<vector>
#include <algorithm>
#include <unordered_set>
using namespace std;

class Solution {
public:
    int countElements(vector<int>& nums, int k) {
        unordered_set<int>x;
        int count=0;
        for(int i = nums.size()-1; i>=0;i--)
        {
            if(x.find(nums[i])==x.end())
            {
                x.insert(nums[i]);
                count++;
            }
        }
        if(count==1 && k!=0) return 0;
        return max(count - k,0);
    }
};
int main()
{
    return 0;
}