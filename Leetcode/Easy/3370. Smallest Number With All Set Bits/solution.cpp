#include<iostream>
using namespace std;
class Solution {
public:
    int smallestNumber(int n) {
        
        int num = 1;
        while(num-1 < n )
        {
            num*=2;
        }
        return num-1;
    }
};

int main()
{
    return 0;
}