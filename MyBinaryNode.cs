using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class MyBinaryNode<TKey> : INode<TKey> where TKey : IComparable<TKey>
    {
        public TKey Key { get; set; }
        public INode<TKey> Left { get; set; }
        public INode<TKey> Right { get; set; }

        public MyBinaryNode(TKey key)
        {
            Key = key;
            Left = null;
            Right = null;
        }
    }
}
