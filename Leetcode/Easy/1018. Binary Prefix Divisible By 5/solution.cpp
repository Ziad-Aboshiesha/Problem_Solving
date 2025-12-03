#include<vector>
#include<iostream>
using namespace std;
class Solution {
public:
    vector<bool> prefixesDivBy5(vector<int>& nums) {
        vector<bool> result(nums.size());
        int current = 0;  

        for (int i = 0; i < nums.size(); i++) {
            if (nums[i] == 0)
                current = (current * 2) % 5;
            else
                current = (current * 2 + 1) % 5;

            result[i] = (current == 0);
        }
        return result;
    }
};
int main()
{
    int val = 0;
    int n =1;
val = ((val << 1) + n) ;
val = ((val << 1) + n) ;
val = ((val << 1) + n) ;


    cout<< val;

    return 0;
}