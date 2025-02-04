
//Data is orgranized using data structures
//Different data structures are used 
// to store and organize data in different ways
//Stack is a data structure that follows LIFO (Last In First Out)
//Queue is a data structure that follows FIFO (First In First Out)
//Linked List is a data structure that stores data in a linear way
//Tree is a data structure that stores data in a hierarchical way
//Graph is a data structure that stores data in a network way
//Hash Table is a data structure that stores data in a key-value pair way
using stackdemo;
using Queuedemo;
using SingularLinkedList;
public class Program
{
    public static void Main()
    {
        /*Stack stack = new Stack();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Display();

        Console.WriteLine(stack.Pop());
        stack.Display();

        stack.Push(120);
        stack.Push(230);
        stack.Display();

        Queue queue = new Queue();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Display();

        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
        queue.Display();

        queue.Enqueue(120);
        queue.Enqueue(230);
        queue.Display();*/
        SinglyLinkedList list = new SinglyLinkedList();
        int choice, data, oldData, newData;

        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Insert Node");
            Console.WriteLine("2. Display List");
            Console.WriteLine("3. Update Node");
            Console.WriteLine("4. Delete Node");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter data to insert: ");
                    data = int.Parse(Console.ReadLine());
                    list.Insert(data);
                    break;

                case 2:
                    list.Display();
                    break;
                    
                case 3:
                    Console.Write("Enter data to update: ");
                    oldData = int.Parse(Console.ReadLine());
                    Console.Write("Enter new data: ");
                    newData = int.Parse(Console.ReadLine());
                    list.Update(oldData, newData);
                    break;

                case 4:
                    Console.Write("Enter data to delete: ");
                    data = int.Parse(Console.ReadLine());
                    list.Delete(data);
                    break;

                case 5:
                    Console.WriteLine("Exiting the program.");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 5);
    }
}