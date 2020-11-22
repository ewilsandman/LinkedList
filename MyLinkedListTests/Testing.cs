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
        public void TestRemoveData()
        {
            //Assign
            MyLinkedList<int> list = new MyLinkedList<int>();
            //Act
            list.AddLast(2);
            list.AddLast(5);
            list.AddLast(3);
            list.AddLast(9);
            list.AddLast(7);
            list.AddLast(1);
            list.Remove(5);
            list.Remove(9);

            //Assert
            Assert.AreEqual(true, list.Contains(2));
            Assert.AreNotEqual(true, list.Contains(5));
            Assert.AreEqual(true, list.Contains(3));
            Assert.AreNotEqual(true, list.Contains(9));
            Assert.AreEqual(true, list.Contains(7));
            Assert.AreEqual(true, list.Contains(1));
        }
        [TestMethod]
        public void TestRemoveNode()
        {
            //Assign
            MyLinkedList<int> list = new MyLinkedList<int>();
            
            //Act
            list.AddLast(2);
            list.AddLast(5);
            list.AddLast(3);
            list.AddLast(9);
            list.AddLast(7);
            list.AddLast(1);
            list.Remove(list.FindNode(5));
            list.Remove(list.FindNode(9));

            //Assert
            Assert.AreEqual(true, list.Contains(2));
            Assert.AreNotEqual(true, list.Contains(5));
            Assert.AreEqual(true, list.Contains(3));
            Assert.AreNotEqual(true, list.Contains(9));
            Assert.AreEqual(true, list.Contains(7));
            Assert.AreEqual(true, list.Contains(1));
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
            var node = list.FindNode(3);
            //Assert
            Assert.AreNotEqual(1, node.Data);
            Assert.AreEqual(3, node.Data);
            Assert.AreNotEqual(4, node.Data);
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
            list.AddLast(1);
            //Assert
            Assert.AreNotEqual(list.Contains(2), true);
            Assert.AreNotEqual(list.Contains(3), true);
            Assert.AreEqual(list.Contains(1), true);
        }
        [TestMethod]
        public void TestForeach()
        {
            //Assign
            MyLinkedList<int> list = new MyLinkedList<int>();
            //Act
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            //node = list.AddLast(3)
            //Assert
            foreach (var item in list)
            {
                Assert.AreEqual(2, item);
            }
        }
        [TestMethod]
        public void TestCount()
        {
            //Assign
            MyLinkedList<int> list = new MyLinkedList<int>();
            //Act
            list.AddLast(2);
            list.AddLast(5);
            list.AddLast(3);
            list.AddLast(9);
            list.AddLast(7);
            list.AddLast(1);
            //Assert
            Assert.AreEqual(list.Count(), 6);
            Assert.AreNotEqual(list.Count(), 5);
        }
        [TestMethod]
        public void TestEnum()
        {
            //Assign

            //Act

            //Assert

        }
        [TestMethod]
        public void TestMoveNext()
        {
            //Assign

            //Act

            //Assert

        }
        [TestMethod]
        public void TestReset()
        {
            //Assign

            //Act

            //Assert

        }
        [TestMethod]
        public void TestDispose()
        {
            //Assign

            //Act

            //Assert

        }
        [TestMethod]
        public void TestIndex()
        {
            //Assign
            MyLinkedList<int> list = new MyLinkedList<int>();
            //Act
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            var hack =list[2];
            //Assert
           // Assert.AreNotEqual(list.Contains(2), true);
        }
    }
}