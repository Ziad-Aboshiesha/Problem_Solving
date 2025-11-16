#include<iostream>
#include<vector>
#include <stack>
using namespace std;

class Solution {
public:
    int minOperations(vector<int>& nums) {
        int count =0;
        stack<int> st ;
        for(int i = 0 ; i< nums.size();i++)
        {
            if(nums[i]==0 ) 
            {
                count+= emptystck(st,-1);
            }
            
            else
            {
                if(st.size()==0 )
                {
                    st.push(nums[i]);
                }
                else
                {
                    count+=emptystck(st,nums[i]);
                }
            }
        }
        count+= emptystck(st,-1);
        return count;
    }
    private :
    int emptystck(stack<int>& st, int stop)
    {
        int temp2 ;
        int count = 0;

        if(st.size()> 0 && st.top()>stop)
        {
            temp2 = st.top();
            st.pop();
            count++;
        }
        while(st.size()>0 && st.top()> stop)
        {
            if(st.top()!= temp2)
            {
                count++;
                temp2 = st.top();
            }
            st.pop();
        }
        if(stop != -1)
        {
            st.push(stop);
        }
    

        return count;
    }
};


int main()
{
    Solution s ;
    vector<int> nums = {0,2};
    cout <<s.minOperations(nums);
    return 0;
}
