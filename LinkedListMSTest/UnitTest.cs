using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;
using System.Collections.Generic;
using System;

namespace LinkedListMSTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Stored_Values_In_Linked_List_Should_Be_Displayed_Correctly()
        {
            List<int> expected = new List<int>() { 32, 34 };
            LinkedListClass testingObj = new LinkedListClass();
            testingObj.Add(32);
            testingObj.Add(34);
            int i = 0;
            foreach (int item in testingObj.GetLinkedListDatas())
            {
                Assert.AreEqual(expected[i], item);
                i++;
            }
        }
        [TestMethod]
        public void No_Values_In_Linked_List_Should_Throw_LinkedListException()
        {
            LinkedListClass testingObj = new LinkedListClass();
            try
            {
                testingObj.GetLinkedListDatas();
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "No data found in Linked List");
            }
        }
        [TestMethod]
        public void Stored_Values_In_Linked_List_Using_Constructor_Should_Be_Displayed_Correctly()
        {
            List<int> expected = new List<int>() { 32, 34 };
            LinkedListClass testingObj = new LinkedListClass(new[] { 32, 34 });
            int i = 0;
            foreach (int item in testingObj.GetLinkedListDatas())
            {
                Assert.AreEqual(expected[i], item);
                i++;
            }
        }
        [TestMethod]
        public void Inserted_Value_At_Any_Position_Should_Be_Displayed_Correctly()
        {
            List<int> expected = new List<int>() { 32, 56, 34, 90, 87 };
            LinkedListClass testingObj = new LinkedListClass(new[] { 32, 34 });
            testingObj.Add(90);
            testingObj.Insert(2, 56);
            testingObj.Add(87);
            int i = 0;
            foreach (int item in testingObj.GetLinkedListDatas())
            {
                Assert.AreEqual(expected[i], item);
                i++;
            }
        }
        [TestMethod]
        public void Deleted_First_Node_Via_Pop_Method_Should_Be_Display_Correctly()
        {
            List<int> expected = new List<int>() {  56, 34, 90 ,87};
            LinkedListClass testingObj = new LinkedListClass(new[] { 32, 34 });
            testingObj.Add(90);
            testingObj.Insert(2, 56);
            testingObj.Add(87);
            testingObj.Pop();
            int i = 0;
            foreach (int item in testingObj.GetLinkedListDatas())
            {
                Assert.AreEqual(expected[i], item);
                i++;
            }
        }
    }
}
