namespace LeetCode.Questions
{
    public class BFS_DFS
    {
        public BFS_DFS() 
        {
            var startNode = new Node()
            {
                Key = "A",
                Left = new Node()
                {
                    Key = "B",
                    Left = new Node()
                    {
                        Key = "C"
                    },
                    Right = new Node()
                    {
                        Key = "D"
                    }
                },
                Right = new Node()
                {
                    Key = "E",
                    Left = new Node()
                    {
                        Key = "F"
                    },
                    Right = new Node()
                    {
                        Key = "G",
                        Left = new Node()
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
