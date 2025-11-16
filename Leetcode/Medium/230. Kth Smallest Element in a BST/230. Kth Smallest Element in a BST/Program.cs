namespace _230._Kth_Smallest_Element_in_a_BST
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
        int count = 0;
        public int ans = 0;
        private void inorder(TreeNode root, int k)
        {
            if (root == null) return;
            inorder(root.left, k);
            count++;
            if(count == k) ans = root.val;
            inorder(root.right, k);
        }
        public int KthSmallest(TreeNode root, int k)
        {
            inorder(root, k);
            return ans;
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
