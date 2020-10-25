﻿using System;
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
            Console.WriteLine($"{data} Added");
        }
        public List<int> GetLinkedListDatas()
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
    }
}
