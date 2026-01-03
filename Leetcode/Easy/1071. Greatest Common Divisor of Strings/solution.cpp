#include<iostream>
using namespace std;

class Solution {
public:
    string gcdOfStrings(string str1, string str2) {
        int m = str1.size();
        int n = str2.size();

        // calc gcd
        int small ;
        int big;
        if(m>n)
        {
            big =m;
            small =n;
        }else{
            big =n;
            small =m;
        }

        while(big % small !=0)
        {
            int temp = big % small;
            big = small ;
            small = temp;
        }
        int gcd = small;
        // extract string gcd
        string ans = str1.substr(0,gcd); //AB

        //compare str1

        int i =0 ;  // point str1
        int k=0; // point ans
//AB , ABABABAB
        while (i < m)
        {
            if(str1[i] != ans[k])
            {
                return "";
            }

            i++;
            k++;
            if(k ==gcd ) k=0;
        }

        int j=0; //point str2
        k=0;

        while (j < n)
        {
            if(str2[j] != ans[k])
            {
                return "";
            }

            j++;
            k++;
            if(k ==gcd ) k=0;
        }
        return  ans;

    }
};

//time : m+n
//space : gcd
int main()
{
    return 0;
}