#include<iostream>
#include<vector>
using namespace std;

class Solution {
public:
    int minDeletionSize(vector<string>& strs) {
        int rows = strs.size();
        int cols = strs[0].size();
        if(cols ==1) return 0;
        vector<int> arr(cols,1);
        int final_answer = 0;

        for(int col = 1 ; col < cols; col++ )
        {
            
            for(int prev = col-1; prev>=0; prev--)
            {
                bool flag = true;
                for(int row = 0 ; row<rows; row++)
                {
                    if(! (strs[row][col]>= strs[row][prev]))
                    {
                        flag = false;
                        break;
                    }
                }
                if(flag ==false) continue;
                arr[col] = max(arr[col], arr[prev] + 1) ;
            }
            final_answer = max(final_answer, arr[col]);
        }

        return cols-final_answer;

    }
};
int main()
{
    Solution s;
    vector<string> arr = {"aaababa","ababbaa"};
    cout<<s.minDeletionSize(arr);
    return 0;
}