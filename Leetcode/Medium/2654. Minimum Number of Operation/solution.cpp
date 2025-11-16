
#include<iostream>
#include<vector>
using namespace std;


class Solution {
public:
    int minOperations(vector<int>& nums) {
        int count = INT_MAX;
        int gcd = nums[0];
        int n = nums.size();
        if(nums[nums.size()-1] ==1)
        {
                int count_i = 1;
                for(int i = 0; i<nums.size()-1;i++)
                {
                    if(nums[i]==1) count_i++;
                }
                return nums.size()-count_i;
        }
        for (int i = 0; i < n - 1; i++) {
            if(nums[i]==1 ) 
            {
                int count_i = 1;
                for(++i; i<nums.size();i++)
                {
                    if(nums[i]==1) count_i++;
                }
                return nums.size()-count_i;
            }
            gcd = CalcGCD(gcd, nums[i + 1]);
            if (gcd == 1) {
                gcd = nums[i + 1];
                int temp = 0;

                for (int j = i; j >= 0; j--) {
                    gcd = CalcGCD(gcd, nums[j]);
                    temp++;
                    if (gcd == 1) {
                        count = min(count, temp);
                        break;
                    }
                }
                gcd = nums[i + 1];
            }
        }

        if (count == INT_MAX)
            return -1;
        else
            return count + n - 1;
    }

private:
    int CalcGCD(int a, int b) {
        if (b > a) swap(a, b);
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
};

int main()
{
    return 0;
}