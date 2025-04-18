using System.Xml.Linq;

namespace _100._Same_Tree
{
 
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
            
        }
    }
    public class Solution
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == q) return true;
            if (p == null) return false;
            if (q == null) return false;
            bool answer = true;
            if (p.val == q.val)
            {
                if (p.left != null && q.left != null && answer)
                {
                    answer = answer && IsSameTree(p.left, q.left);

                }
                else if (p.left != q.left && answer)
                {
                    answer = false;

                }
                if (p.right != null && q.right != null && answer)
                {
                    answer = answer && IsSameTree(p.right, q.right);

                }
                else if (p.right  != q.right && answer)
                {
                    answer = false;
                }
            }
            else
            {
                answer = false;
            }

            return answer;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            TreeNode node2 = new TreeNode(2);
            TreeNode node3 = new TreeNode(3);

            TreeNode root = new TreeNode(1, node2, null);
            TreeNode root2 = new TreeNode(1, node2, null);
            Console.WriteLine(s.IsSameTree(root, root2));

        }
    }
}
