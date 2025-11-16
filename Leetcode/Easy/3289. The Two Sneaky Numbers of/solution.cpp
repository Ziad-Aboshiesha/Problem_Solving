#include<iostream>
#include<vector>
#include <unordered_set>


using namespace std;

class Solution {
public:
    vector<int> getSneakyNumbers(vector<int>& nums) {
        unordered_set<int> appeared ;
        vector<int> answer ;
        for(int i = 0 ; i < nums.size(); i++)
        {
            if(appeared.find(nums[i])== appeared.end())
            {
                appeared.insert(nums[i]);
            }else 
            {
                answer.push_back(nums[i]);
                if(answer.size() ==2)
                {
                    break; 
                }
            }
        }
        return answer;
    }
};

int main()
{

    return 0;
}