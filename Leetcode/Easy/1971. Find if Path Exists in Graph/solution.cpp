#include<iostream>
#include<vector>
#include<queue>
using namespace std;
class Solution {
public:
    bool validPath(int n, vector<vector<int>>& edges, int source, int destination) {
        vector<vector<int>> grph(n);
        for (int i = 0 ; i < edges.size(); i++)
        {
            grph[edges[i][0]][edges[i][1]] =1 ;
        }
        queue<int> q;
        q.push(source);
        while(q.size())
        {
            int temp = q.front();
            q.pop();
            for(int i = 0 ; i < n ; i++)
            {
                if(grph[temp][i]==1)
                {
                    if(i==destination) return true;
                    q.push(i);
                }
            }
        }
        return false;
    }
};

int main()
{

}