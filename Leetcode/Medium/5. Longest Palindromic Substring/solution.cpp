#include<iostream>
#include<vector>
using namespace std;
class Solution {
public:
    string longestPalindrome(string s) {
        int len = 1;
        int start=0;
        string ans;
        for(int i = 0 ; i < s.size();i++)
        {
            if(i>0 && i<s.size()-1 && s[i-1]==s[i+1] )
            {
                int temp_len =3;
                int temp_start = i-1;
                int count = 2;
                while(i+count<s.size() && i-count>=0 && s[i+count] ==s[i-count])
                {
                    temp_len+=2;
                    temp_start = i-count;
                    count++;
                }
                if(temp_len>len)
                {
                    len = temp_len;
                    start = temp_start;
                }
                
            }
            if(i>0 && s[i]==s[i-1])
            {
                int temp_len=2;
                int temp_start=i-1;
                int count=1;
                while(i+count<s.size() && i-count-1>=0 && s[i+count] ==s[i-count-1])
                {
                    temp_len+=2;
                    temp_start = i-count-1;
                    count++;
                }
                if(temp_len>len)
                {
                    len = temp_len;
                    start = temp_start;
                }
            }
        }
        return s.substr(start, len);
    }
};
int main()
{
    return 0;
}