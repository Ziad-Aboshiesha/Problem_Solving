#include<iostream>
#include<vector>
using namespace std;
class Solution {
public:
    int minimumOperations(vector<int>& nums) {
        int sum = 0;
        for(int i = 0 ; i <nums.size();i++)
        {
            if(nums[i]%3!=0) sum++;
        }
        return sum;
    }
};
int main()
{
    Solution s;
     vector<int> ss = {1,2,3,4};
    cout<<s.minimumOperations(ss);
    return 0;
}