#include<iostream>
#include<vector>
#include <algorithm>
using namespace std;
class Solution {
public:
    int intersectionSizeTwo(vector<vector<int>>& intervals) {
        int a=-1;
        int b = -1;
        int ans= 0;
        sort(intervals.begin(), intervals.end(), [](const vector<int>& a, const vector<int>& b) {
            if (a[1] == b[1])
                return a[0] < b[0];   
            return a[1] < b[1];      
        });
        for(int i = 0 ; i < intervals.size(); i++)
        {
            if(a==-1 &&b==-1)
            {
                a= intervals[i][1]-1;
                b= intervals[i][1];
                ans+=2;
            }
            else
            {
                if(intervals[i][0]<= b)
                {
                    if(intervals[i][0]<= a)
                    {
                        continue;
                    }
                    else
                    {
                        if(b==intervals[i][1])
                        {
                            a = intervals[i][1]-1;
                        }else{
                            a=b;
                            b=intervals[i][1];
                            
                        }
                        ans+=1;
                    }
                    // int temp = b - intervals[i][0] + 1 ;
                    // if(temp==1)
                    // {
                    //     a=b;
                    //     b=intervals[i][1];
                    //     ans+=1;
                    // }
                    // else
                    // {
                    //     continue;
                    // }
                }else
                {
                    a= intervals[i][1]-1;
                    b= intervals[i][1];
                    ans+=2;
                }
            }
        }
        return ans;

    }
};
int main()
{
    vector<vector<int>> intervals ={{1,3},{3,7},{5,7},{7,8}};
    Solution s ;
    cout<<s.intersectionSizeTwo(intervals);

}
