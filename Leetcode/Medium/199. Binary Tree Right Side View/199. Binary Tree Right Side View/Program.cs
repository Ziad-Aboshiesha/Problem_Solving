namespace _199._Binary_Tree_Right_Side_View
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
        public IList<int> RightSideView(TreeNode root)
        {
            List<int> ans = new List<int>();
            if (root == null) return ans;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            
            ans.Add(root.val);
            Queue<TreeNode> temp = new Queue<TreeNode>();

            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                

                if (node.right != null) { temp.Enqueue(node.right); }

                if (node.left != null) { temp.Enqueue(node.left); }
                if (queue.Count == 0 && ( temp.Count > 0))
                {
                    TreeNode tempo = temp.Peek();
                    ans.Add( tempo.val);
                    while (temp.Count > 0)
                    {

                        TreeNode tempNode = temp.Dequeue();
                        queue.Enqueue(tempNode);
                    }
                }
            }
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
