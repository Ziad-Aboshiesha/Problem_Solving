#include<iostream>
#include<vector>
using namespace std;
class Solution {
public:
    int maxOperations(string s) {
        int count_ones = 0;
        int ans = 0;
        for(int i = 0; i < s.size(); i++)
        {
            if(s[i]=='1')
            {
                count_ones++;
            }
            else if(s[i]=='0' && i != 0 && s[i-1]=='1')
            {
                ans+=count_ones;
            }
        }
        return ans;
    }
};
int main()
{
return 0;
}