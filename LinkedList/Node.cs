using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    public class Node :IComparable
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
        public int CompareTo(object obj)
        {
            Node NodeToCompare = (Node)obj;
            if(NodeToCompare.data>data)
                return 1;
            else if(NodeToCompare.data < data)
                return -1;
            else
                return 0;
        }
    }
}
