namespace LeetCode.Questions
{
    public class BFS_DFS
    {
        public BFS_DFS() 
        {
            var startNode = new BinaryTreeNode()
            {
                Key = "A",
                Left = new BinaryTreeNode()
                {
                    Key = "B",
                    Left = new BinaryTreeNode()
                    {
                        Key = "C"
                    },
                    Right = new BinaryTreeNode()
                    {
                        Key = "D"
                    }
                },
                Right = new BinaryTreeNode()
                {
                    Key = "E",
                    Left = new BinaryTreeNode()
                    {
                        Key = "F"
                    },
                    Right = new BinaryTreeNode()
                    {
                        Key = "G",
                        Left = new BinaryTreeNode()
                        {
                            Key = "H"
                        }
                    }
                }
            };

            Console.WriteLine("Breadth First Traversal");
            BreadthFirstTraversal(startNode);

            Console.WriteLine();

            Console.WriteLine("Depth First Traversal");
            DepthFirstTraversal(startNode);
        }

        private void BreadthFirstTraversal(BinaryTreeNode node)
        {
            Queue<BinaryTreeNode> queue = new Queue<BinaryTreeNode>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                Console.Write($"{item.Key} ");

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

        private void DepthFirstTraversal(BinaryTreeNode node)
        {
            if (node == null)
            {
                return;
            }

            Console.Write($"{node.Key} ");

            DepthFirstTraversal(node.Left);
            DepthFirstTraversal(node.Right);
        }
    }
    internal class BinaryTreeNode
    {
        public string Key { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }
    }
}
