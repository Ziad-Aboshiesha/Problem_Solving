#include<iostream>
#include<vector>
using namespace std;
class Solution {
public:
    int minDistance(string word1, string word2) {
        vector<vector<int>> dp(word1.size() + 1, vector<int>(word2.size() + 1, 0)) ;
        int count = calc(word1,word2,word1.size()-1,word2.size()-1);
        return count;
    }
    private :
    int calc(string& word1,string& word2, int i , int j)
    {
        if(i<0 )
        {
            return j+1;
        }
        if(j<0)
        {
            return i+1;
        }
        int count = 0 ;
        if(word1[i]==word2[j])
        {
            return calc(word1,word2, i-1,j-1);
        }
        else
        {
            int one = calc(word1,word2, i-1,j);
            int two = calc(word1,word2, i,j-1);
            int three = calc(word1,word2, i-1,j-1);
            int minimum = min(one ,two);
            minimum = min (minimum, three );
            count = 1 +minimum;
        }
        return count ;
    }
};

int main()
{
    return 0;
}