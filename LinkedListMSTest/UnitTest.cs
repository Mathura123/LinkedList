using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListProblem;
using System.Collections.Generic;
using System;

namespace LinkedListMSTest
{
    [TestClass]
    public class UnitTest
    {
        
        [TestMethod]
        public void Deleted_A_Node_Should_Throw_LinkedListException_When_Data_Is_Not_Present()
        {
            try
            {
                LinkedList testingObj = new LinkedList();
                testingObj.Add(90);
                testingObj.Add(34);
                testingObj.Add(89);
                testingObj.Delete(35);
            }
            catch(Exception e)
            {
                Assert.AreEqual(e.Message, "35 not found in Linked List");
            }
        }
        [TestMethod]

    }
}
