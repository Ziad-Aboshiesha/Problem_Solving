#include<iostream>
#include <vector>
using namespace std;

class Solution {
public:
    int numTeams(vector<int>& rating) {
        int n = rating.size();
        vector<int> increasing (n,0);
        vector<int> decreasing (n,0);
        int count_inc = 0;
        int count_dec = 0;
        for(int i = 1; i < n; i++ )
        {
            int count_second_inc = 0;
            int count_second_dec = 0;
            for(int j = i-1; j>=0; j--)
            {
                if(rating[i] > rating[j])
                {
                    count_second_inc++;
                    count_inc+=increasing[j];
                }
                else if(rating[i] < rating[j])
                {
                    count_second_dec++;
                    count_dec+= decreasing[j];
                }
            }
            increasing[i]= count_second_inc;
            decreasing[i]= count_second_dec;


        }
        return count_dec + count_inc;
    }
};
int main()
{

    Solution s ;
    vector<int> nums = {2,5,3,4,1};
    cout<<s.numTeams(nums);
    return 0;
}