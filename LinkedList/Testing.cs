using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}