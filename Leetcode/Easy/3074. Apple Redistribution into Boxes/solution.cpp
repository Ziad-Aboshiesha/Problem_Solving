#include<iostream>
#include<vector>
#include <algorithm>
using namespace std;

class Solution {
public:
    int minimumBoxes(vector<int>& apple, vector<int>& capacity) {
        sort(capacity.begin(),capacity.end(), std::greater<int>());
        int sum=0;
        int ans = 0;
        for(int a : apple)
        {
            sum +=a;
        }
        for(int i =0; i < capacity.size();i++)
        {
            sum -= capacity[i];
            ans++;
            if(sum<=0) break;
        }
        return ans;
    }
};

int main()
{
    return 0;
}