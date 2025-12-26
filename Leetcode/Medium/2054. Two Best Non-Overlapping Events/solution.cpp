#include<iostream>
#include<vector>
using namespace std;

class Solution {
public:
    int maxTwoEvents(vector<vector<int>>& events) {
        int ans = 0;
        for(int i =0 ; i < events.size(); i++)
        {
            ans = max(ans, events[i][2]);
            for(int j = i+1; j<events.size();j++)
            {
                if(events[j][0] > events[i][1] || events[i][0] > events[j][1] )
                {
                    ans = max(ans, events[i][2]+ events[j][2]);
                    
                }
            }
        }
        return ans;
    }
};
int main()
{
    return 0;
}