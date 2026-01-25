#include<iostream>
#include<vector>
#include<algorithm>
#include<climits>
using namespace std;

class Solution {
public:
    int minimumDifference(vector<int>& nums, int k) {
          if (k==1) return 0;
        sort(nums.begin(),nums.end());
        int current = k-1;
        int ans =INT_MAX;
        int size = nums.size();
        while(current <size)
        {
            if(nums[current]  -nums[ current - k +1 ] < ans)
            {
                ans = nums[current]  -nums[ current-k +1] ;
            }
            current++;
        }

        return ans;
    }
};

int main()
{
	Solution s;
	vector<int> nums = {9,4,1,7};
	cout<<s.minimumDifference(nums, 2);
	return 0;
}
