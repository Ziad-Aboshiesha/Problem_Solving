#include<iostream>
using namespace std;
class Solution {
public:
    int maxProduct(int n) {
        int largest= -INT_MAX;
        int secondlargest = -INT_MAX;
        while(n!=0)
        {
            int temp = n%10;
            if(temp > largest)
            {
                secondlargest = largest;
                largest = temp;
            }else if (temp> secondlargest)
            {
                secondlargest = temp;
            } n = n /10;
        }
        return largest * secondlargest;

    }
};
int main()
{

}