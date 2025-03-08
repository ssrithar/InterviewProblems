namespace InterviewProblems
{
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
    public class TreeProblems
    {
        public TreeProblems()
        {
            TreeNode root = new TreeNode(3);
            root.Left = new TreeNode(5);
            root.Right = new TreeNode(1);
            root.Left.Left = new TreeNode(6);
            root.Left.Right = new TreeNode(2);
            root.Right.Left = new TreeNode(0);
            root.Right.Right = new TreeNode(8);
            root.Left.Right.Left = new TreeNode(7);
            root.Left.Right.Right = new TreeNode(4);

            DepthFirstSearch(root);
            Console.WriteLine();

            BreadthFirstSearch(root);
            Console.WriteLine();

            PrintNodeAndLevel(root);
        }

        public void DepthFirstSearch(TreeNode treeNode)
        {
            if (treeNode == null)
            {
                return;
            }

            Console.Write(treeNode.Value);

            DepthFirstSearch(treeNode.Left);
            DepthFirstSearch(treeNode.Right);
        }

        public void BreadthFirstSearch(TreeNode treeNode)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(treeNode);

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                Console.Write(item.Value);

                if (item.Left != null)
                {
                    queue.Enqueue(item.Left);
                }

                if (item.Right != null)
                {
                    queue.Enqueue(item.Right);
                }
            }
        }

        public void PrintNodeAndLevel(TreeNode treeNode)
        {
            if (treeNode == null)
            {
                return;
            }

            Queue<(TreeNode node, int level)> queue = new Queue<(TreeNode, int)>();
            queue.Enqueue((treeNode, 0));

            while (queue.Count > 0)
            {
                var (node, level) = queue.Dequeue();
                Console.WriteLine($"Node: {node.Value}, Level: {level}");

                if (node.Left != null)
                {
                    queue.Enqueue((node.Left, level + 1));
                }

                if (node.Right != null)
                {
                    queue.Enqueue((node.Right, level + 1));
                }
            }
        }
    }
}