using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkeListClass
    {
        public Node head;
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if(head==null)
            {
                head = newNode;
            }
            else
            {
                Node tempNode = head;
                while(tempNode.next!=null)
                {
                    tempNode = tempNode.next;
                }
                tempNode.next = newNode; 
            }
        }
        public List<int> Display()
        {
            if(head==null)
                throw new LinkedListException(LinkedListException.ExceptionType.NO_DATA, "No data found in Linked List");
            else
            {
                List<int> dataList = new List<int>();
                Node tempNode = head;
                while(tempNode!=null)
                {
                    dataList.Add(tempNode.data);
                    tempNode = tempNode.next;
                }
                return dataList;
            }
        }
    }
}
