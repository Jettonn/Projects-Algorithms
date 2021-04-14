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

        public int Length(){
            Node currentNode = head;
            int count = 0;
            while(currentNode!=null){
                count++;
                currentNode = currentNode.next;
            }
            return count;
        }

        public string Display(){
            Node currentNode = head;
            string nodes = "";
            while (currentNode!=null)
            {
                nodes += currentNode.data.ToString() + " ";
                currentNode = currentNode.next;
            }
            return nodes;
        }

        public int Max(){
            Node currentNode = head;
            int max = currentNode.data;
             while (currentNode!=null)
            {
                if(max<currentNode.data)
                    max = currentNode.data;
                currentNode = currentNode.next;
            }
            return max;
        }

        public int Min(){
            Node currentNode = head;
            int min = currentNode.data;
             while (currentNode!=null)
            {
                if(min>currentNode.data)
                    min = currentNode.data;
                currentNode = currentNode.next;
            }
            return min;
        }

        public double Average(){
            Node currentNode = head;
            int sum = 0;
            int count = 0;
             while (currentNode!=null)
            {
                sum+=currentNode.data;
                count++;
                currentNode = currentNode.next;
            }
            return (double)sum/count;
        }
    }
}