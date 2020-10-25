﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedListException : Exception
    {
        public enum ExceptionType
        {
            NO_DATA
        }
        private ExceptionType type;
        public LinkedListException(ExceptionType type, string message):base(message)
        {
            this.type = type;
        }
    }
}