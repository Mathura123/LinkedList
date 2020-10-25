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
            linkedListObj.Add(30);
            linkedListObj.Add(70);
            Display(linkedListObj);
        }
        static void Display(LinkedListClass linkedListObj)
        {
            try
            {
                Console.WriteLine();
                foreach (int data in linkedListObj.GetLinkedListDatas())
                    Console.Write($"{data} -> ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
