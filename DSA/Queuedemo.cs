using System;
using System.Collections.Generic;

namespace Queuedemo{
    public class Queue
    {
        private List<int> elements; 
        public Queue()
        {
            elements = new List<int>(); 
        }

        public void Enqueue(int element)
        {
            elements.Add(element);
        }

        public int? Dequeue()
        {
            if (elements.Count == 0)
            {
                return null;
            }
            int theElement = elements[0];
            elements.RemoveAt(0); 
            return theElement;
        }

        public void Display()
        {
            Console.WriteLine(string.Join(", ", elements));
        }
    }
}