class LowestCommonParent
{
    public LowestCommonParent()
    {
        TreeNode root = new TreeNode(3) {
            left = new TreeNode(5) {
                left = new TreeNode(6),
                right = new TreeNode(2) {
                    left = new TreeNode(7),
                    right = new TreeNode(4)
                }
            },
            right = new TreeNode(1) {
                left = new TreeNode(0),
                right = new TreeNode(8)
            }
        };

        Console.WriteLine(LowestCommonAncestor(root, 6,  8).val);
    }

    public TreeNode LowestCommonAncestor(TreeNode root, int p, int q)
    {
        Console.WriteLine($"Root Val is {root?.val} ");
        if (root == null || root.val == p || root.val == q) {            
            return root;
        }

        TreeNode left = LowestCommonAncestor(root.left, p, q);
        TreeNode right = LowestCommonAncestor(root.right, p, q);

        var retNode = left != null && right != null ? root : left ?? right;
        Console.WriteLine();
        Console.WriteLine($"Return Node Val is {retNode?.val}");

        return retNode;
    }
}