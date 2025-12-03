#include<iostream>
#include<vector>
#include <algorithm>
#include <unordered_set>
using namespace std;

class Solution {
public:
    int maxDistinct(string s) {
        unordered_set<char> x;
        int count = 0;
        for(int i =0; i<s.size();i++)
        {
            if(x.find(s[i])==x.end())
            {
                count++;
                x.insert(s[i]);
            }
        }
        return count;
    }
};