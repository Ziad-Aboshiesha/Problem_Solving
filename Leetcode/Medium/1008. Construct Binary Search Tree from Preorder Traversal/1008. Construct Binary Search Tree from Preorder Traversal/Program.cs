namespace _1008._Construct_Binary_Search_Tree_from_Preorder_Traversal;

public class Solution
{
    public TreeNode BstFromPreorder(int[] preorder)
    {
        if (preorder == null || preorder.Length == 0) return null;
        TreeNode root = new TreeNode(preorder[0]);
        var left = new List<int>();
        var right = new List<int>();
        for (int i = 1; i < preorder.Length; i++)
        {
            if (preorder[i] < root.val) left.Add(preorder[i]);
            else right.Add(preorder[i]);
        }
        root.left = BstFromPreorder(left.ToArray());
        root.right = BstFromPreorder(right.ToArray());
        return root;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
