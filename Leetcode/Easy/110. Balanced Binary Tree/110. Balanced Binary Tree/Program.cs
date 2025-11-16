namespace _110._Balanced_Binary_Tree
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
        bool ans = true;
        private int calc(TreeNode root)
        {
            if(root == null) return 0;
            int max_l = calc(root.left);
            int max_r = calc(root.right);
            if(Math.Abs(max_l - max_r) >1)
            {
                ans = false;
            }
            return 1 + Math.Max(max_l, max_r);

        }
        public bool IsBalanced(TreeNode root)
        {

            calc(root);
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
            Solution s  = new Solution();
            Console.WriteLine(s.IsBalanced(root));
        }
    }
}
