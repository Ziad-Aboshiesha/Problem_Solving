namespace _98._Validate_Binary_Search_Tree
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
        List<int> list = new List<int>();
        private void inorder(TreeNode root)
        {
            if(root == null) return;
            inorder(root.left);
            list.Add(root.val);
            inorder(root.right);
        }
        public bool IsValidBST(TreeNode root)
        {
            inorder(root);
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i+1] < list[i]) return false;
            }
            return true;
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
