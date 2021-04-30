namespace TreesToDo1
{
    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Data { get; set; }

        public Node(int item)
        {
            Data = item;
            Left = Right = null;
        }
    }

    public class BinaryTree
    {
        public Node Root { get; set; }

        public void Add(int value)
        {
            Node newNode = new Node(value);

            Node current = Root;
            Node previous = current;

            while (current != null)
            {
                if (value < current.Data)
                {
                    previous = current;
                    current = current.Left;
                }
                else
                {
                    previous = current;
                    current = current.Right;
                }
            }

            if (Root == null)
                Root = newNode;
            else
            {
                if (value < previous.Data)
                    previous.Left = newNode;
                else
                    previous.Right = newNode;
            }
        }

        public bool Contains(int value)
        {
            if (Root == null)
                return false;

            if (Root.Data == value)
                return true;

            Node current = Root;
            while (current != null)
            {
                if (value == current.Data)
                    return true;
                else if (value < current.Data)
                    current = current.Left;
                else
                    current = current.Right;
            }
            return false;
        }

        public int Min()
        {
            Node current = Root;

            while (current.Left != null)
            {
                current = current.Left;
            }

            return current.Data;
        }

        public int Max()
        {
            Node current = Root;

            while (current.Left != null)
            {
                current = current.Right;
            }

            return current.Data;
        }

        public int Size()
        {
            return (Size(Root));
        }
        private int Size(Node node)
        {
            if (node == null) return 0;
            else
            {
                return (Size(node.Left) + 1 + Size(node.Right));
            }
        }

        public bool IsEmpty()
        {
            if (Root == null)
                return true;
            else
                return false;
        }
    }
}