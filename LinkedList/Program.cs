using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Assignment");
            Console.WriteLine("=================================");
            LinkeListClass linkedListObj = new LinkeListClass();
            linkedListObj.Add(1);
            linkedListObj.Add(2);
            try
            {
                foreach (int data in linkedListObj.Display())

                {
                    Console.WriteLine(data);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
