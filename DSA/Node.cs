namespace SingularLinkedList
{
    class Node
    {
        public int Data;
        public Node Next;
        public Person person;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }

        public Node(Person person)
        {
            this.person = person;
        }
    }

}