#include<iostream>
using namespace std;

class Solution {
public:
    double myPow(double x, int n) {
        if(n==0) return 1;
        if(x==0 || x==1) return x;
        long loops = n;
        if(n<0)
        {
            loops =n;
            loops = -loops;
            x = 1/x;
        }
        double temp = x;
        for(int i = 1 ;i<loops;i++)
        {
            x=x*temp;
        }
        return x;
    }
};
int main()
{
    cout<<INT_MAX;
}