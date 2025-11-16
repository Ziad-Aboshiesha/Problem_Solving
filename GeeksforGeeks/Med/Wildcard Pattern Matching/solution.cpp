#include<iostream>
#include<vector>
using namespace std;
class Solution {
    public:
        bool wildCard(string &txt, string &pat) {
            int i = 0;
            int j = 0;
            while(i<txt.size() && j < pat.size())
            {
                if( pat[j]=='?' )
                {
                    i++;
                    j++;
                }
                else if ( pat[j]=='*' )
                {
                    
                }
            }
        }
};
int main()
{
    return 0;
}