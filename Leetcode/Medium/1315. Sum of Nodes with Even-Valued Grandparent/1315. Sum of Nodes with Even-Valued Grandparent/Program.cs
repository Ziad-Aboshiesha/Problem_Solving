using System.Collections;

namespace _1315._Sum_of_Nodes_with_Even_Valued_Grandparent
{
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
    public class Solution
    {
        public int SumEvenGrandparent(TreeNode root)
        {
            if (root == null) return 0;
            int sum = 0;    
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0) 
            {
                TreeNode temp = queue.Dequeue();
                if ( temp.val %2 == 0 )
                {
                    sum += temp.right.right.val;
                    sum += temp.right.left.val;
                    sum += temp.left.left.val;
                    sum += temp.left.right.val;

                }
                if(temp.right != null)
                {
                    queue.Enqueue(temp.right);
                }
                if (temp.left != null)
                {
                    queue.Enqueue(temp.left);
                }
            }
            return sum;
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
