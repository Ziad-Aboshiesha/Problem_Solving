namespace _101._Symmetric_Tree
{

    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            bool first = root.left == null;
            bool second= root.right== null;

            bool answer = true;
            if (root == null) return false;
            if (first && second) return true;
            if (first || second) return false;
            if(root.left.val != root.right.val) return false;
            answer = check(root.left, root.right);
            return answer;
        }
        public bool check(TreeNode left, TreeNode right)
        {
            bool answer = true;
            if(left.val != right.val ) return false;
            if(left.left != null && right.right != null)
            {
                answer = answer &&check(left.left, right.right);
            }
            else if((left.left != null && right.right == null)|| (left.left == null && right.right != null))
            {
                answer = false;
            }
            if (left.right != null && right.left!= null)
            {
                answer = answer && check(left.right, right.left);
            }
            else if ((left.right != null && right.left == null) || (left.right == null && right.left != null))
            {
                answer = false;
            }
            return answer;
        }
    }
    public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) 
      {
          this.val = val;
          this.left = left;
          this.right = right;
      }
    }
 
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            TreeNode node3 = new TreeNode(3);
            TreeNode node4 = new TreeNode(4);
            TreeNode node2l = new TreeNode(2, node3, node4);
            TreeNode node2r = new TreeNode(2, node4, node3);
            TreeNode root = new TreeNode(1, node2l, node2r);
            Console.WriteLine( solution.IsSymmetric(root));
        }

    }
}
