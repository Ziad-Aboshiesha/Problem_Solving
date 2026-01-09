#include<iostream>
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
    int max_depth ; 
    int MaxDepth(TreeNode* root)
    {
        if(root == NULL) return 0;

        return 1 + max(MaxDepth(root->left) , MaxDepth(root->right));
    }
    TreeNode* getAns(TreeNode* root, int current_level)
    {
        if(root==NULL) return NULL;
        TreeNode* left = getAns(root->left, current_level+1);
        TreeNode* right = getAns(root->right, current_level+1);
        if(current_level == max_depth)
        {
            return root;
        }
        if(left != NULL && right != NULL)
        {
            return root;
        }
        if(left != NULL) return left;
        if(right != NULL) return right;
        return NULL;
    }
    TreeNode* subtreeWithAllDeepest(TreeNode* root) {
        max_depth =  MaxDepth(root);
        TreeNode* ans = getAns(root, 1);
        return ans;
    }
};