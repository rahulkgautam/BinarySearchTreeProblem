using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main()
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(50);
            binaryTree.Add(30);
            binaryTree.Add(20);
            binaryTree.Add(40);
            binaryTree.Add(70);
            binaryTree.Add(60);
            binaryTree.Add(80);

            int totalNodes = binaryTree.Size();
            Console.WriteLine($"Total nodes in the binary tree: {totalNodes}");
        }
    }
}
