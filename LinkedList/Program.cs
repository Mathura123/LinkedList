using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Assignment");
            Console.WriteLine("=================================");
            LinkedListClass linkedListObj = new LinkedListClass(new[] { 20, 70, 33 });
            linkedListObj.Add(32);
            linkedListObj.Add(34);
            try
            {
                foreach (int data in linkedListObj.Display())
                    Console.WriteLine(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
