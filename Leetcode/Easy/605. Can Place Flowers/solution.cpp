#include<iostream>
#include<vector>

using namespace std;


class Solution {
public:
    bool canPlaceFlowers(vector<int>& flowerbed, int n) {
        if(n==0) return true;
        int sz = flowerbed.size();

        for(int i =0 ; i < sz ; i++)
        {
            if(flowerbed[i] ==0)
            {
                bool right= false;
                bool left = false;

                if(i==0 || flowerbed[i-1] == 0)
                {
                    left = true;
                }
                if(i== sz-1 || flowerbed[i+1] == 0)
                {
                    right = true;
                }
                if(left && right)
                {
                    n--;
                    flowerbed[i] = 1;
                }
                if(n==0)return true;
            }
        }
        return  false;
    }
};

//time : o(n)
//space : o(1)