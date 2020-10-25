using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;
using System.Collections.Generic;

namespace LinkedListMSTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Stored_Values_In_Linked_List_Should_Be_Displayed_Correctly()
        {
            List<int> expected = new List<int>() { 32,34};
            LinkeListClass testingObj = new LinkeListClass();
            testingObj.Add(32);
            testingObj.Add(34);
            int i = 0;
            foreach(int item in testingObj.Display())
            {
                Assert.AreEqual(expected[i], item);
                i++;
            }
        }
    }
}
