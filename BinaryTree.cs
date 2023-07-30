using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        private TreeNode root;

        public BinaryTree()
        {
            root = null;
        }

        public void Add(int value)
        {
            root = AddNode(root, value);
        }

        private TreeNode AddNode(TreeNode current, int value)
        {
            if (current == null)
            {
                return new TreeNode(value);
            }

            if (value < current.Value)
            {
                current.Left = AddNode(current.Left, value);
            }
            else if (value > current.Value)
            {
                current.Right = AddNode(current.Right, value);
            }
            else
            {
                // Value already exists, do nothing.
            }

            return current;
        }

        public int Size()
        {
            return CountNodes(root);
        }

        private int CountNodes(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            return 1 + CountNodes(node.Left) + CountNodes(node.Right);
        }
    }
}
