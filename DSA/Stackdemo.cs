using System;
using System.Reflection.Metadata.Ecma335;

namespace stackdemo
{
    public class Stack
    {
        private List<int> elements; 
        public Stack()
        {
            elements = new List<int>();
        }

        public void Push(int element)
        {
            elements.Add(element);
        }

        public int? Pop()
        {
            if (elements.Count == 0)
            {
                return null; 
            }
            int theElement = elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);
            return theElement;
        }

        public void Display()
        {
            Console.WriteLine(string.Join(", ", elements));
        }
    }
}
