namespace _700._Search_in_a_Binary_Search_Tree
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
        public TreeNode SearchBST(TreeNode root, int val)
        {
            while (root != null)
            {
                if (root.val == val)
                    return root;
                else if (root.val > val)
                    root = root.left;
                else
                    root = root.right;
            }
            return null;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(4);
            root.left = new TreeNode(2);
            root.right = new TreeNode(7);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(3);
            Solution  s     = new Solution();
            Console.WriteLine(s.SearchBST(root,2).val);
        }
    }
}
