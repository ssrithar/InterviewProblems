public class InvertBinaryTree
{
    public InvertBinaryTree()
    {
        TreeNode root = new TreeNode(4);
        root.left = new TreeNode(2);
        root.right = new TreeNode(7);
        root.left.left = new TreeNode(1);
        root.left.right = new TreeNode(3);
        root.right.left = new TreeNode(6);
        root.right.right = new TreeNode(9);

        Console.WriteLine("Original Binary Tree:");
        PrintTree(root);

        InvertTree(root);

        Console.WriteLine("\nInverted Binary Tree:");
        PrintTree(root);
    }

    public TreeNode InvertTree(TreeNode node)
    {
        if (node != null)
        {
            TreeNode temp = node.left;
            
            node.left = node.right;
            node.right = temp;
            InvertTree(node.left);
            InvertTree(node.right);
        }

        return node;
    }

    public void PrintTree(TreeNode node)
    {
        if (node == null) return;
        
        Console.Write($"{node.val} ");
        PrintTree(node.left);
        PrintTree(node.right);
    }
}