namespace _104._Maximum_Depth_of_Binary_Tree
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
        public int MaxDepth(TreeNode root)
        {
            if(root == null) return 0;

            int maxr = MaxDepth(root.right);
            int maxl = MaxDepth(root.left);


            return 1+ Math.Max(maxl, maxr);
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
