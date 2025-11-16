namespace _450._Delete_Node_in_a_BST
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
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            TreeNode parent = null;
            TreeNode current = root;

            // Step 1: Find the node to delete
            while (current != null && current.val != key)
            {
                parent = current;
                if (key < current.val)
                    current = current.left;
                else
                    current = current.right;
            }

            if (current == null) return root; // Not found

            // Step 2: Handle 3 cases

            // Case 1: Node has no children
            if (current.left == null && current.right == null)
            {
                if (parent == null) return null; // only root
                if (parent.left == current) parent.left = null;
                else parent.right = null;
            }

            // Case 2: Node has one child
            else if (current.left == null || current.right == null)
            {
                TreeNode child = (current.left != null) ? current.left : current.right;

                if (parent == null)
                    return child; // root was deleted

                if (parent.left == current) parent.left = child;
                else parent.right = child;
            }

            // Case 3: Node has two children
            else
            {
                // Find inorder successor (smallest in right subtree)
                TreeNode successorParent = current;
                TreeNode successor = current.right;

                while (successor.left != null)
                {
                    successorParent = successor;
                    successor = successor.left;
                }

                // Copy successor value
                current.val = successor.val;

                // Delete successor node
                if (successorParent.left == successor)
                    successorParent.left = successor.right;
                else
                    successorParent.right = successor.right;
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
