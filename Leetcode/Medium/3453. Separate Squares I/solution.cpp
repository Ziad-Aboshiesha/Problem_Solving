#include<iostream>
using namespace std;
#include<vector>
class Solution {
public:
    double separateSquares(vector<vector<int>>& squares) {
        int maxi = 0;
        double total_area;
        int n = squares.size();
        for(int i =0 ; i < n ; i++)
        {
            total_area += (double)squares[i][2] * squares[i][2];
            maxi = max(maxi, squares[i][1] + squares[i][2]);
        }
        double start = 0;
        double end = maxi;
        double ans = INT_MAX;
        while(end - start > 1e-5)
        {
            
            double mid = (start + end) /2.0;
            
            double area_below =0;
            for(int i =0 ; i < n ; i++)
            {
                double h;
                if(squares[i][1] > mid )continue;
                if(mid < squares[i][1] + squares[i][2])
                {
                    h = mid - squares[i][1];
                }else{
                    h = squares[i][2];
                }
                area_below += (double) h * squares[i][2];
            }
            double area_above = total_area - area_below ;
            if(area_below == area_above )
            {
                end = mid;
                if(ans >mid)
                {
                    ans = mid;
                }
                
            }
            if(area_below > area_above)
            {
                end = mid;
            }
            if(area_below < area_above)
            {
                start = mid;
            }
        }
        return ans;
    }
};

int main()
{
    Solution s ;
    vector<vector<int>> test = {{0,0,2},{1,1,1}};
    cout<<s.separateSquares(test);
}