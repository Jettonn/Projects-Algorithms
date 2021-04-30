using System;

namespace TreesToDo1
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            BinaryTree binaryTree2 = new BinaryTree();
            binaryTree.Add(40);
            binaryTree.Add(30);
            binaryTree.Add(60);
            binaryTree.Add(35);
            binaryTree.Add(25);
            Console.WriteLine(binaryTree.Contains(35));
            Console.WriteLine(binaryTree.Contains(25));
            Console.WriteLine(binaryTree.Contains(75));
            Console.WriteLine(binaryTree.Contains(60));
            Console.WriteLine("Min value: " + binaryTree.Min());
            Console.WriteLine("Max value: " + binaryTree.Max());
            Console.WriteLine("Binary tree size: " + binaryTree.Size());
            Console.WriteLine("Binary tree isEmpty: " + binaryTree.IsEmpty());
            Console.WriteLine("Binary tree isEmpty: " + binaryTree2.IsEmpty());
        }
    }
}
