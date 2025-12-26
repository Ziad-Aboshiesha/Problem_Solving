#include<vector>
#include<iostream>
using namespace std;
class Solution {
public:
    int maximumPopulation(vector<vector<int>>& logs) {
        vector<int> pop(101, 0);
        int n = logs.size();
        for(int i =0 ;  i < n;i++)
        {
            pop[logs[i][0] - 1950]++;
            pop[logs[i][1] - 1950]--;

        }
        int max=0;
        int current =0;
        int ans=0;
        for(int i = 0 ; i < 101;i++)
        {
            current += pop[i];
            if(current>max)
            {
                max = current;
                ans = i+1950; 
            }
        }
        return ans;
    }
};


int main()
{

    return 0;
}