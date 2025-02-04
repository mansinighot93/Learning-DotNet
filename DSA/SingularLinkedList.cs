namespace SingularLinkedList{
    class Node
    {
        public int Data;
        public Node Next;
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
    class SinglyLinkedList
    {
        private Node head;
        public void Insert(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            Console.WriteLine("Node inserted successfully.");
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }
            Node current = head;
            Console.Write("Linked List: ");
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
        public void Update(int oldData, int newData)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == oldData)
                {
                    current.Data = newData;
                    Console.WriteLine("Node updated successfully.");
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("Node with data {0} not found.", oldData);
        }

        public void Delete(int data)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }
            if (head.Data == data)
            {
                head = head.Next;
                Console.WriteLine("Node deleted successfully.");
                return;
            }
            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                    Console.WriteLine("Node deleted successfully.");
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("Node with data {0} not found.", data);
        }
    }
}