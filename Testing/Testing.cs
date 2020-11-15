using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;

namespace Testing
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

            //Act

            //Assert

        }
        [TestMethod]
        public void TestFind()
        {
            //Assign

            //Act

            //Assert

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