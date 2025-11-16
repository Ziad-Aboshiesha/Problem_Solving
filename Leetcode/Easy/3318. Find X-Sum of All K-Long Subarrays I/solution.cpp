#include<iostream>
#include<vector>
#include<unordered_map>
#include<queue>
using namespace std;

class Solution {
public:
    vector<int> findXSum(vector<int>& nums, int k, int x) {
        vector<int>ans;
        unordered_map<int,int> freq;
        for(int i = 0; i < k; i++) {
            freq[nums[i]]++;
        }
        ans.push_back(calc(freq,x));
        int z = 0;
        for(int i = k; i<nums.size();i++,z++)
        {
            freq[nums[i]]++;
            freq[nums[z]]--;
            if(freq[nums[z]] < 1)
            {
                freq.erase(nums[z]);
            }
            ans.push_back(calc(freq,x));

        }
        return ans;
    }
    int calc(unordered_map<int,int> freq,int x)
    {
        priority_queue<pair<int, int>, vector<pair<int, int>>, greater<pair<int, int>>> pq;
        for(auto i : freq)
        {
            pq.push({i.second,i.first});
            if(pq.size() > x)
            {
                pq.pop();
            }
        }
        int sum = 0;
        while(pq.size() !=0 )
        {
            sum+=pq.top().second *pq.top().first ;
            pq.pop();
        }
        return sum;
        
    }
};
int main()
{
    Solution s ;
    vector<int> nums = {1,1,2,2,3,4,2,3};
    vector<int> ans = s.findXSum(nums,6,2);
    return 0;
}