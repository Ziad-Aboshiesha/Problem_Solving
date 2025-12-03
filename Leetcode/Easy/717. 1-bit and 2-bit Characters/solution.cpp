#include<iostream>
#include<vector>
using namespace std;

class Solution {
public:
    bool isOneBitCharacter(vector<int>& bits) {
        int n = bits.size();
        if(n==1 || bits[n-2]==0)
        {
            return true;
        }
        for(int i = 0 ;i<n;i++)
        {
            if(i==n-1) return true;
            if(bits[i]==1)
            {
                i++;
            }
        }
        return false;
    }
};
int main()
{
    Solution s ;

    vector<int> nums = {1,1,1,0};
    cout<<s.isOneBitCharacter(nums);
    return 0;
}