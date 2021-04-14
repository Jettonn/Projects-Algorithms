using System;

namespace SinglyLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            SLL singleLinkedLists = new SLL();
            singleLinkedLists.AddFront(1);
            singleLinkedLists.AddFront(2);
            singleLinkedLists.AddFront(3);
            singleLinkedLists.AddFront(4);
            singleLinkedLists.AddFront(5);
            singleLinkedLists.AddFront(6);
            singleLinkedLists.AddFront(7);
            singleLinkedLists.PrintAllNodes();
            Console.WriteLine(singleLinkedLists.Front());
            Console.WriteLine("-------------------");
            singleLinkedLists.RemoveFront();
            singleLinkedLists.PrintAllNodes();
            Console.WriteLine(singleLinkedLists.Contains(3));
            Console.WriteLine(singleLinkedLists.Contains(7));
            Console.WriteLine(singleLinkedLists.Length());
            Console.WriteLine(singleLinkedLists.Display());
            Console.WriteLine(singleLinkedLists.Max());
            Console.WriteLine(singleLinkedLists.Min());
            Console.WriteLine(singleLinkedLists.Average());
        }
    }
}
