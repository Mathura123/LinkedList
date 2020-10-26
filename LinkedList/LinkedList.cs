using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    public class LinkedList
    {
        protected Node head;
        public LinkedList()
        {
        }
        public LinkedList(int[] datas)
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
        private List<int> GetLinkedListDatas()
        {
            if (head == null)
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
        protected void DoInsert(int position, int data)
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
            }
            catch
            {
                throw new LinkedListException(LinkedListException.ExceptionType.OUT_OF_RANGE, "The position entered is out of Range");
            }
        }
        protected void DoDelete(int data)
        {
            int position = DoSearch(data);
            Node tempNode = head;
            if (position == 1)
            {
                head = head.next;
            }
            else
            {
                for (int i = 0; i < position - 2; i++)
                {
                    tempNode = tempNode.next;
                }
                tempNode.next = tempNode.next.next;
            }
        }
        protected int DoSearch(int data)
        {
            List<int> datasList = GetLinkedListDatas();
            for (int i = 0; i < datasList.Count; i++)
            {
                if (datasList[i] == data)
                {
                    return i + 1;
                }
            }
            throw new LinkedListException(LinkedListException.ExceptionType.NOT_IN_LIST, $"{data} not found in Linked List");
        }
        public virtual void Pop()
        {
            if (head == null)
            {
                throw new LinkedListException(LinkedListException.ExceptionType.NO_DATA, "No data found in Linked List");
            }
            else
            {
                Console.WriteLine($"{head.data} at first position DELETED");
                head = head.next;
            }
        }
        public virtual void PopLast()
        {
            if (head == null)
                throw new LinkedListException(LinkedListException.ExceptionType.NO_DATA, "No data found in Linked List");
            else
            {
                Node tempNode = head;
                while ((tempNode.next).next != null)
                {
                    tempNode = tempNode.next;
                }
                Console.WriteLine($"{tempNode.next.data} at last position DELETED");
                tempNode.next = null;
            }
        }
        protected void DeleteNode(Node nodeToBeDeleted)
        {
            Node tempNode = head;
            int position = 1;
            while((tempNode.data!=nodeToBeDeleted.data) || (tempNode.next!=nodeToBeDeleted.next))
            {
                position++;
                tempNode = tempNode.next;
            }
            tempNode = head;
            if (position == 1)
            {
                head = head.next;
            }
            else
            {
                for (int i = 0; i < position - 2; i++)
                {
                    tempNode = tempNode.next;
                }
                tempNode.next = tempNode.next.next;
            }
        }
        public virtual void Display()
        {
            try
            {
                foreach (int data in GetLinkedListDatas())
                    Console.Write($"{data} -> ");
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Insert(int position,int data)
        {
            DoInsert(position, data);
            Console.WriteLine($"{data} INSERTED at position {position}");
        }
        public void Delete(int data)
        {
            DoDelete(data);
            Console.WriteLine($"{data} DELETED");
        }
        public void Search(int data)
        {
            int position =DoSearch(data);
            Console.WriteLine($"{data} FOUND at position {position}");
        }
    }
}
