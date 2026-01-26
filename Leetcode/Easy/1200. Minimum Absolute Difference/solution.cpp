#include<iostream>
#include<vector>
#include<algorithm>
#include<climits>

using namespace std;

class Solution {
public:
    vector<vector<int>> minimumAbsDifference(vector<int>& A) {
        sort(A.begin(), A.end());
        int minDiff = INT_MAX;
        vector<vector<int>> res;

        for (int i = 1; i < A.size(); i++) {
            int diff = A[i] - A[i - 1];
            if (diff < minDiff) {
                minDiff = diff;
                res = {};
                res.push_back({A[i - 1], A[i]});
            } else if (diff == minDiff)
                res.push_back({A[i - 1], A[i]});
        }

        return res;
    }
};
int main()
{
	Solution s ;
	vector<int> test = {1,3,4,9,10};
	vector<vector<int>>res =  s.minimumAbsDifference(test);
	for(int i =0 ; i< res.size();i++)
	{
		cout<<res[i][0] << " " << res[i][1]<<endl;
		
	}
	return 0;
}
