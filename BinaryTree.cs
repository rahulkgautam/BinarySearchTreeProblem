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

        public bool Search(int value)
        {
            return SearchNode(root, value);
        }

        private bool SearchNode(TreeNode node, int value)
        {
            if (node == null)
            {
                return false;
            }

            if (value == node.Value)
            {
                return true;
            }
            else if (value < node.Value)
            {
                return SearchNode(node.Left, value);
            }
            else
            {
                return SearchNode(node.Right, value);
            }
        }
    }
}
