public class MaxDepthBinaryTree
{
    public MaxDepthBinaryTree()
    {
        TreeNode root = new TreeNode(3);
        root.left = new TreeNode(9);
        root.right = new TreeNode(20);
        root.right.left = new TreeNode(15);
        root.right.right = new TreeNode(7);

        int maxDepth = MaxDepth(root);
        Console.WriteLine($"Max Depth of Binary Tree: {maxDepth}");
    }

    public int MaxDepth(TreeNode node)
    {
        if (node == null) return 0;
        Console.WriteLine($"Node Value: {node.val}");
        return Math.Max(MaxDepth(node.left), MaxDepth(node.right)) + 1;
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}