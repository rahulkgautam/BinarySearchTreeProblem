using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class BinarySearchTree<TKey> where TKey : IComparable<TKey>
    {
        private INode<TKey> root;

        public void Add(TKey key)
        {
            root = AddNode(root, key);
        }

        private INode<TKey> AddNode(INode<TKey> current, TKey key)
        {
            if (current == null)
            {
                return new MyBinaryNode<TKey>(key);
            }

            int comparison = key.CompareTo(current.Key);

            if (comparison < 0)
            {
                current.Left = AddNode(current.Left, key);
            }
            else if (comparison > 0)
            {
                current.Right = AddNode(current.Right, key);
            }
            else
            {
                // Key already exists, do nothing or update the value if needed.
            }

            return current;
        }
    }
}
