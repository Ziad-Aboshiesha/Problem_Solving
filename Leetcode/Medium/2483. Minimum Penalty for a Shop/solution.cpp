#include<iostream>
using namespace std;


class Solution {
public:
    int bestClosingTime(string customers) {
        int max_profit=0;
        int day = 0;
        int current = 0;
        for(int i =0 ; i < customers.size(); i++)
        {
            if(customers[i] == 'Y' )
            {
                current++;
                if(current > max_profit)
                {
                    max_profit = current;
                    day = i + 1 ;  
                }
            }else
            {
                current--;
            }
        }
        return day;
    }
};


int main()
{
    return 0;
}