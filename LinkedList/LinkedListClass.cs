using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedListClass
    {
        private Node head;
        public LinkedListClass()
        {
        }
        public LinkedListClass(int[] datas)
        {
            foreach (int data in datas)
            {
                Add(data);
            }
        }
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node tempNode = head;
                while (tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }
                tempNode.next = newNode;
            }
            Console.WriteLine($"{data} ADDED");
        }
        public List<int> GetLinkedListDatas()
        {
            if(head==null)
                throw new LinkedListException(LinkedListException.ExceptionType.NO_DATA, "No data found in Linked List");
            else
            {
                List<int> dataList = new List<int>();
                Node tempNode = head;
                while (tempNode != null)
                {
                    dataList.Add(tempNode.data);
                    tempNode = tempNode.next;
                }
                return dataList;
            }
        }
        public void Insert(int position, int data)
        {
            try
            {
                Node newNode = new Node(data);
                if (position == 1)
                {
                    newNode.next = head;
                    head = newNode;
                }
                else
                {
                    Node tempNode = head;
                    int i = 2;
                    while (i != position)
                    {
                        tempNode = tempNode.next;
                        i++;
                    }
                    newNode.next = tempNode.next;
                    tempNode.next = newNode;
                }
                Console.WriteLine($"{data} INSERTED at position {position}");
            }
            catch
            {
                throw new LinkedListException(LinkedListException.ExceptionType.OUT_OF_RANGE, "The position entered is out of Range");
            }
        }
        public void Pop()
        {
            if(head==null)
            {
                throw new LinkedListException(LinkedListException.ExceptionType.NO_DATA, "No data found in Linked List");
            }
            else
            {
                Console.WriteLine($"{head.data} at first position DELETED");
                head = head.next;
            }
        }
        public void PopLast()
        {
            if (head == null)
                throw new LinkedListException(LinkedListException.ExceptionType.NO_DATA, "No data found in Linked List");
            else
            {
                Node tempNode = head;
                while((tempNode.next).next!=null)
                {
                    tempNode = tempNode.next;
                }
                Console.WriteLine($"{tempNode.next.data} at last position DELETED");
                tempNode.next= null;
            }
        }
    }
}
