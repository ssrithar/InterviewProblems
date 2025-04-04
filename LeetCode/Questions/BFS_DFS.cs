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

        private void InOrderTraversalBFS(BinaryTreeNode node)
        {
            if (node == null)
            {
                return;
            }

            Stack<BinaryTreeNode> stack = new Stack<BinaryTreeNode>();
            BinaryTreeNode current = node;

            while (stack.Count > 0 || current != null)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }

                current = stack.Pop();
                Console.Write($"{current.Key} ");

                current = current.Right;
            }
        }

        private void PreOrderTraversalBFS(BinaryTreeNode node)
        {
            if (node == null)
            {
                return;
            }

            Stack<BinaryTreeNode> stack = new Stack<BinaryTreeNode>();
            stack.Push(node);

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                Console.Write($"{current.Key} ");

                if (current.Right != null)
                {
                    stack.Push(current.Right);
                }

                if (current.Left != null)
                {
                    stack.Push(current.Left);
                }
            }
        }

        private void PostOrderTraversal(BinaryTreeNode node)
        {
            if (node == null)
            {
                return;
            }

            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.Write($"{node.Key} ");
        }
        private void LevelOrderTraversalBFS(BinaryTreeNode node)
        {
            if (node == null)
            {
                return;
            }

            Queue<BinaryTreeNode> queue = new Queue<BinaryTreeNode>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;

                for (int i = 0; i < levelSize; i++)
                {
                    var current = queue.Dequeue();
                    Console.Write($"{current.Key} ");

                    if (current.Left != null)
                    {
                        queue.Enqueue(current.Left);
                    }

                    if (current.Right != null)
                    {
                        queue.Enqueue(current.Right);
                    }
                }

                Console.WriteLine(); // Move to the next line after each level
            }
        }
    }
}
internal class BinaryTreeNode
{
    public string Key { get; set; }
    public BinaryTreeNode Left { get; set; }
    public BinaryTreeNode Right { get; set; }
}

