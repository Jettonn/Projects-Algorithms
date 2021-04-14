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
            singleLinkedLists.PrintAllNodes();
            Console.WriteLine(singleLinkedLists.Front());
            singleLinkedLists.RemoveFront();
            singleLinkedLists.PrintAllNodes();
        }
    }
}
