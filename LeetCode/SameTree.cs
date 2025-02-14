public class SameTree
{
    List<int> tree1 = new List<int>();
    List<int> tree2 = new List<int>();

    public SameTree()
    {
        TreeNode p = new TreeNode(1);
        p.left = new TreeNode(2);
        p.right = new TreeNode(3);

        TreeNode q = new TreeNode(1);
        q.left = new TreeNode(2);
        q.right = new TreeNode(3);

        bool isSame = IsSameTree(p, q);
        Console.WriteLine($"Are the two trees the same? {isSame}");

        IsSameTree(p, ref tree1);
        IsSameTree(q, ref tree2);
        var isSameTree = tree1.SequenceEqual(tree2) ? "same" : "not same";
        Console.WriteLine($"Tree p is {isSameTree} as tree q.");
    }

    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null) return true;
        if (p == null || q == null) return false;
        return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }

    public void IsSameTree(TreeNode tree, ref List<int> treeList)
    {
        if (tree == null) return;
        treeList.Add(tree.val);
        IsSameTree(tree.left, ref treeList);
        IsSameTree(tree.right, ref treeList);
    }
}