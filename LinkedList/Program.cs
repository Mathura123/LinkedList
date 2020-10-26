using LinkedList;
using System;

namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Assignment");
            Console.WriteLine("=================================");
            Console.WriteLine("\nWorking on Simple Linked List");
            ILinkedList linkedListObj = new LinkedList();
            linkedListObj.Add(56);
            linkedListObj.Add(9);
            linkedListObj.Add(70);
            linkedListObj.Insert(2, 30);
            linkedListObj.Insert(1, 40);
            linkedListObj.Delete(40);
            linkedListObj.Display();

            Console.WriteLine("\nWorking on Sorted Linked List");
            ILinkedList sortedLinkedListObj = new SortedLinkedList();
            sortedLinkedListObj.Add(45);
            sortedLinkedListObj.Add(4);
            sortedLinkedListObj.Add(9);
            sortedLinkedListObj.Add(-45);
            sortedLinkedListObj.Add(9);
            sortedLinkedListObj.Add(7);
            sortedLinkedListObj.Pop();
            sortedLinkedListObj.PopLast();
            sortedLinkedListObj.Display();
        }
    }
}
