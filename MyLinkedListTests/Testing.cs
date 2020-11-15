using System;
using MyLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MyLinkedListTests
{
    [TestClass]
    public class TestMethod
    {
        [TestMethod]
        public void TestAddition()
        {
            //Assign
            MyLinkedList<int> list = new MyLinkedList<int>();
            int value = 5;

            //Act
            var node = list.AddFirst(value);
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(4);

            //Assert
            Assert.AreEqual(value, node.Data);
            Assert.AreEqual(4, list.Count);
            Assert.AreEqual(true, list.Contains(3));
        }
        [TestMethod]
        public void TestRemoval()
        {
            //Assign
            MyLinkedList<int> list = new MyLinkedList<int>();
            int value = 5;
            //Act
            var node = list.AddFirst(value);
            list.AddFirst(2);
            list.Remove(2);
            //Assert
            Assert.AreEqual(value, node.Data);
            Assert.AreNotEqual(true, list.Contains(2));
        }
        [TestMethod]
        public void TestFind()
        {
            //Assign
            MyLinkedList<int> list = new MyLinkedList<int>();
            int value = 5;
            //Act
            var node = list.AddFirst(value);
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(4);
            var found = list.Find(2);
            //Assert
            Assert.AreEqual(2, found);
        }
        [TestMethod]
        public void TestClear()
        {
            //Assign

            //Act

            //Assert

        }
    }
}