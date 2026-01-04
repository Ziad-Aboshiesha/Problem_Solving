#include<iostream>
using namespace std;
#include<vector>
#include <cmath> 
class Solution {
public:
    int sumFourDivisors(vector<int>& nums) {
        int ans =0;
        for(int i =0 ; i < nums.size(); i++)
        {
            int div = 0;
            for(int j =2 ; j <= sqrt(nums[i]); j++)
            {
                if(nums[i] % j ==0)
                {
                    if(div != 0) 
                    {
                        div = 0;
                        break;
                    }
                    else div = j;
                }
            }
            if(div != 0 && div != (nums[i] / div))
            {
                ans += nums[i] + 1 + div + (nums[i] / div);
            }
        }


        return ans;
    }
};


int main()
{

}