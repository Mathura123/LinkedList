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
            List<int> expected = new List<int>() { 56, 34, 90, 87 };
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
        [TestMethod]
        public void Deleted_Last_Node_Via_PopLast_Method_Should_Be_Display_Correctly()
        {
            List<int> expected = new List<int>() { 56, 34, 90 };
            LinkedListClass testingObj = new LinkedListClass(new[] { 32, 34 });
            testingObj.Add(90);
            testingObj.Insert(2, 56);
            testingObj.Add(87);
            testingObj.Pop();
            testingObj.PopLast();
            int i = 0;
            foreach (int item in testingObj.GetLinkedListDatas())
            {
                Assert.AreEqual(expected[i], item);
                i++;
            }
        }
        [TestMethod]
        public void Search_Should_Return_Position_Of_Data_When_Data_IS_Present()
        {
            int expected = 1;
            LinkedListClass testingObj = new LinkedListClass();
            testingObj.Add(90);
            testingObj.Add(87);
            int result = testingObj.Search(90);
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void Search_Should_Throw_LinkedLIstException_When_Data_IS_Not_Present()
        {
            try
            {
                LinkedListClass testingObj = new LinkedListClass();
                testingObj.Add(90);
                testingObj.Add(87);
                int result = testingObj.Search(79);
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "79 not found in Linked List");
            }
        }
        [TestMethod]
        public void Deleted_A_Node_Should_Display_Correctly_When_Data_Is_Present()
        {
            List<int> expected = new List<int>() { 90, 89 };
            LinkedListClass testingObj = new LinkedListClass();
            testingObj.Add(90);
            testingObj.Add(34);
            testingObj.Add(89);
            testingObj.Delete(34);
            int i = 0;
            foreach (int item in testingObj.GetLinkedListDatas())
            {
                Assert.AreEqual(expected[i], item);
                i++;
            }
        }
    }
}
