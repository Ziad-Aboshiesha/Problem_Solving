using System.Xml.Linq;

namespace _102._Binary_Tree_Level_Order_Traversal
{
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }
 
    public class Solution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> ans = new List<IList<int>>();
            if (root == null)  return ans; 
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int index = 0;
            ans.Add( new List<int>());
            Queue<TreeNode> temp = new Queue<TreeNode>();

            while (queue.Count > 0) 
            {
                TreeNode node = queue.Dequeue();
                ans[index].Add(node.val);
                
                if (node.left != null) { temp.Enqueue(node.left); }

                if (node.right!= null) { temp.Enqueue(node.right); }
                if (queue.Count == 0 && (node.left != null || node.right != null || temp.Count>0))
                {
                    ans.Add(new List<int>());
                    index++;
                    while(temp.Count > 0)
                    {
                        TreeNode tempNode = temp.Dequeue();
                        queue.Enqueue(tempNode);
                    }
                }
            }
            return ans;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode node15 = new TreeNode(15);
            TreeNode node7 = new TreeNode(7);
            TreeNode node9 = new TreeNode(9);

            // Create node 20 and attach its children
            TreeNode node20 = new TreeNode(20, node15, node7);

            // Create the root node (3) and attach its children
            TreeNode root = new TreeNode(3, node9, node20);
            Solution s = new Solution();
            s.LevelOrder(root);
        }
    }
}
