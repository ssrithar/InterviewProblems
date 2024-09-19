using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode.Questions
{
    public class RemoveDupsInUnsortedBinaryTree
    {
        public List<char> visited = new List<char>();        
        private Stack<UnsortedBinaryTreeNode> parents = new Stack<UnsortedBinaryTreeNode>();
        private Stack<UnsortedBinaryTreeNode> orphaned = new Stack<UnsortedBinaryTreeNode>();
        private Stack<UnsortedBinaryTreeNode> leaf = new Stack<UnsortedBinaryTreeNode>();

        public RemoveDupsInUnsortedBinaryTree()
        {
            var root = SetupBinaryTree();

            RecurseNode(root);

            var leafNode = leaf.Pop();

            while (leafNode != null)
            {
                leafNode.left = orphaned.TryPeek(out UnsortedBinaryTreeNode poppedNodeLeft) ? poppedNodeLeft : null;
                leafNode.right = orphaned.TryPeek(out UnsortedBinaryTreeNode poppedNodeRight) ? poppedNodeRight : null;
                leafNode = leaf.TryPeek(out UnsortedBinaryTreeNode poppedLeafNode) ? poppedLeafNode : null;
            }
        }
        private UnsortedBinaryTreeNode SetupBinaryTree()
        {
            UnsortedBinaryTreeNode binaryTree = new UnsortedBinaryTreeNode
            (
                'A',
                new UnsortedBinaryTreeNode
            (
                    'B',
                    new UnsortedBinaryTreeNode
                    (
            'D'
                    ),
                    new UnsortedBinaryTreeNode
                    (
                        'E'
            )
                ),
                new UnsortedBinaryTreeNode
            (
            'C',
                    new UnsortedBinaryTreeNode
                    (
            'A',
                        new UnsortedBinaryTreeNode
                        (
                            'G'
            ),
                        new UnsortedBinaryTreeNode
                        (
                            'H'
                        )
                    ),
            new UnsortedBinaryTreeNode
                    (
                        'F'
                    )
                )
            );

            return binaryTree;
        }

        private void RecurseNode(UnsortedBinaryTreeNode current)
        {
            if (current == null)
            {
                return;
            }

            if (current.left != null || current.right != null)
            {
                parents.Push(current);
            }
            else if (current.left == null && current.right == null)
            {
                leaf.Push(current);
            }

            if (!visited.Any(n => n == current.name))
            {
                visited.Add(current.name);
                RecurseNode(current.left);
                RecurseNode(current.right);
            }
            else
            {
                parents.Pop();
                var parent = parents.Peek();
                parent.left = current.left;
                orphaned.Push(current.right);
                RecurseNode(current.right);
            }
        }
    }

    internal class UnsortedBinaryTreeNode
    {
        public char name;
        public UnsortedBinaryTreeNode left;
        public UnsortedBinaryTreeNode right;
        char value;

        public UnsortedBinaryTreeNode(char value, UnsortedBinaryTreeNode node1 = null, UnsortedBinaryTreeNode node2 = null)
        {
            this.name = value;
            this.left = node1;
            this.right = node2;
        }

        
    }
}
