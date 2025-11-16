#include<iostream>
#include<vector>
using namespace std;


class Solution {
public:
    int numSub(string s) {
        int count = 0 ;
        int ans = 0;
        for(int i = 0 ; i < s.size(); i ++)
        {
            if(s[i]=='1') count ++;
            else if(count >0)
            {
                ans+= (count * (count + 1) ) /2;
                count = 0;
            }
        }
        ans+= (count * (count + 1) ) /2;
        return ans;
    }
};
int main()
{
    return 0;

}