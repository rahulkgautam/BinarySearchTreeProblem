using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public interface INode<TKey> where TKey : IComparable<TKey>
    {
        TKey Key { get; set; }
        INode<TKey> Left { get; set; }
        INode<TKey> Right { get; set; }
    }
}
