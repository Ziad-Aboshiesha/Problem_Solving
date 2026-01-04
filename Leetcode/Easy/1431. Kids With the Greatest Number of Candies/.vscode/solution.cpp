#include<iostream>
#include<vector>
using namespace std;
class Solution {
public:
    vector<bool> kidsWithCandies(vector<int>& candies, int extraCandies) {
        int n = candies.size();
        vector<bool> answer (n, false);

        int max =-1;
        // max value
        for(int i : candies)
        {
            if (i> max) max =i;
        }
        //compare
// 2,3,5,1,3  extra 3
// t,t,t,f,t
        for(int i =0; i < n ; i++)
        {
            if ( candies[i] + extraCandies >= max)
            {
                answer[i]=true;
            }
        }
        return answer;
    }
};
//time : n
//space : n 

int main()
{
    return 0;
}