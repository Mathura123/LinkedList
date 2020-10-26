using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    public interface ILinkedList
    {
        public void Display();
        public void Add(int data);
        public void Insert(int position, int data);
        public void Delete(int data);
        public void Search(int data);
        public void Pop();
        public void PopLast();
    }
}
