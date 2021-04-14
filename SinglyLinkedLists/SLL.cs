using System;

namespace SinglyLinkedLists
{
    public class SLL
    {
        Node head = new Node(0);

        public SLL()
        {
            head = null;
        }

        public Node AddFront(int value){
            Node newNode = new Node(value);

            newNode.next = head;

            head = newNode;

            return head;
        }

        public Node RemoveFront(){
            if(head != null){
                head = head.next;
                return head;
            }
            return null;
        }

        public int? Front(){
            if(!String.IsNullOrEmpty(head.data.ToString())){
                return head.data;
            }
            return null;
        }

        public void PrintAllNodes(){
            Node currentNode = head;
            while (currentNode!=null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;
            }
        }

        public bool Contains(int value){
            Node currentNode = head;
            bool contains = false;
            while (currentNode!=null)
            {
                if(currentNode.data == value)
                    contains = true;
                currentNode = currentNode.next;
            }
            return contains;
        }
    }
}