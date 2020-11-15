using System;
using MyLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MyLinkedListTests
{
    [TestClass]
    public class TestMethod
    {
        [TestMethod]
        public void TestAddContains()
        {
            //Assign
            MyLinkedList<int> list = new MyLinkedList<int>();

            //Act
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddFirst(8);

            //Assert
            Assert.AreEqual(true, list.Contains(3));
            Assert.AreEqual(list.Count(), 4);
           Assert.AreEqual(true, list.Contains(8));
        }
        [TestMethod]
        public void TestRemoval()
        {
            //Assign
            MyLinkedList<int> list = new MyLinkedList<int>();
            //Act
            list.AddLast(2);
           // list.Remove(2);
            //Assert
            Assert.AreNotEqual(true, list.Contains(2));
        }
        [TestMethod]
        public void TestFind()
        {
            //Assign
            MyLinkedList<int> list = new MyLinkedList<int>();
            //Act
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
           // var found = list.Find(2);
            //Assert
          //  Assert.AreEqual(2, found);
        }
        [TestMethod]
        public void TestClear()
        {
            //Assign
            MyLinkedList<int> list = new MyLinkedList<int>();
            //Act
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.Clear();
            //Assert
            Assert.AreNotEqual(list.Contains(2), true);
        }
    }
}