using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Assignment");
            Console.WriteLine("=================================");
            LinkedListClass linkedListObj = new LinkedListClass();
            linkedListObj.Add(56);
            linkedListObj.Add(70);
            linkedListObj.Insert(2, 30);
            Display(linkedListObj);
            linkedListObj.Pop();
            linkedListObj.Insert(2, 45);
            linkedListObj.Insert(4, 99);
            Display(linkedListObj);
            linkedListObj.PopLast();
            Display(linkedListObj);
        }
        static void Display(LinkedListClass linkedListObj)
        {
            try
            {
                foreach (int data in linkedListObj.GetLinkedListDatas())
                    Console.Write($"{data} -> ");
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
