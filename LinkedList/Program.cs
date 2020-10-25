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
            //linkedListObj.Add(56);
            //linkedListObj.Add(70);
            //linkedListObj.Insert(2, 30);
            //int key = linkedListObj.Search(30);
            //linkedListObj.Insert(key+1, 40);
            //Display(linkedListObj);
            linkedListObj.Delete(40);
            //Display(linkedListObj);
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
