namespace _226._Invert_Binary_Tree
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
        public TreeNode InvertTree(TreeNode root)
        {
            if (root != null)
            {


                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    TreeNode node = queue.Dequeue();
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                    TreeNode temp = node.left;
                    node.left = node.right;
                    node.right = temp;
                }
            }
            return root;
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
