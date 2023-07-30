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
            binaryTree.Add(63);
            binaryTree.Add(80);

            int targetValue = 63;
            bool isFound = binaryTree.Search(targetValue);
            if (isFound)
                Console.WriteLine($"{targetValue} is present in the binary tree.");
            else
                Console.WriteLine($"{targetValue} is not present in the binary tree.");
            
        }
    }
}
