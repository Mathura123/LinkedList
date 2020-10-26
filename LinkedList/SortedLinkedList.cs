using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    public class SortedLinkedList : LinkedList, ILinkedList
    {
        public SortedLinkedList()
        {
        }
        public SortedLinkedList(int[] datas) : base(datas)
        {
        }
        private List<int> Sort()
        {
            if (head == null)
                throw new LinkedListException(LinkedListException.ExceptionType.NO_DATA, "No data found in Linked List");
            else
            {
                List<int> datasList = new List<int>();
                Node tempNode = head;
                Node tempLeastNode = head;
                int position = 1;
                while (tempLeastNode.next != null)
                {
                    Node leastNode = tempLeastNode;
                    while (tempNode.next != null)
                    {
                        if (leastNode.CompareTo(tempNode.next) < 0)
                        {
                            leastNode = tempNode.next;
                        }
                        tempNode = tempNode.next;
                    }
                    int tempLeastData = leastNode.data;
                    DeleteNode(leastNode);
                    DoInsert(position, tempLeastData);
                    int i = 0;
                    tempLeastNode = head;
                    while (i < position)
                    {
                        tempLeastNode = tempLeastNode.next;
                        i++;
                    }
                    tempNode = tempLeastNode;
                    position++;
                }
                tempNode = head;
                while (tempNode != null)
                {
                    datasList.Add(tempNode.data);
                    tempNode = tempNode.next;
                }
                return datasList;
            }
        }
        public new void PopLast()
        {
            if (head == null)
                throw new LinkedListException(LinkedListException.ExceptionType.NO_DATA, "No data found in Linked List");
            else
            {
                Sort();
                Node tempNode = head;
                while ((tempNode.next).next != null)
                {
                    tempNode = tempNode.next;
                }
                Console.WriteLine($"{tempNode.next.data} at last position DELETED");
                tempNode.next = null;
            }
        }
        public new void Pop()
        {
            if (head == null)
            {
                throw new LinkedListException(LinkedListException.ExceptionType.NO_DATA, "No data found in Linked List");
            }
            else
            {
                Sort();
                Console.WriteLine($"{head.data} at first position DELETED");
                head = head.next;
            }
        }
        public new void Display()
        {
            try
            {
                foreach (int data in Sort())
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