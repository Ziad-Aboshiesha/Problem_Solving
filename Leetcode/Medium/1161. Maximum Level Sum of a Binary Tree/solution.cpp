#include<iostream>
#include<queue>

using namespace std;


  struct TreeNode {
      int val;
      TreeNode *left;
      TreeNode *right;
      TreeNode() : val(0), left(nullptr), right(nullptr) {}
      TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
      TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
  };
 
class Solution {
public:
    int maxLevelSum(TreeNode* root) {
        int current_sum =0;
        int max_sum = root->val;
        int current_level=0;
        int max_level =1;

        queue<TreeNode*> q;
        q.push(root);


        while(!q.empty())
        {
            int sz = q.size();
            current_sum = 0;
            current_level++;

            while(sz != 0)
            {
                sz--;
                TreeNode* temp = q.front();
                q.pop();
                current_sum += temp->val;
                if(temp->left != NULL)
                {
                    q.push(temp->left);
                }
                if(temp->right != NULL)
                {
                    q.push(temp->right);
                }
            }
            if(current_sum > max_sum)
            {
                max_sum = current_sum;
                max_level = current_level;
            }
        }

        return max_level;
    }
};

//time : o(n)
//space : o(W)

int main()
{
    return 0;
}