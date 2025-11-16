namespace _543._Diameter_of_Binary_Tree
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
        int longest = 0;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            height(root);
            return longest;
        }
        public int height (TreeNode root)
        {
            if (root == null) return 0;
            int maxr = height(root.right);
            int maxl = height(root.left);
            longest = Math.Max(longest, maxr + maxl + 1);
            return 1 + Math.Max(maxr, maxl);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
