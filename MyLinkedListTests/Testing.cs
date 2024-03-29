﻿using System;
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
            Assert.AreEqual(4, list.Count());
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
            list.Remove(list.Find(5));
            list.Remove(list.Find(9));

            //Assert
            Assert.AreEqual(true, list.Contains(2));
            Assert.AreNotEqual(true, list.Contains(5));
            Assert.AreEqual(true, list.Contains(3));
            Assert.AreNotEqual(true, list.Contains(9));
            Assert.AreEqual(true, list.Contains(7));
            Assert.AreEqual(true, list.Contains(1));
            Assert.ThrowsException<ArgumentNullException>(() => list.Remove(list.Find(0)));
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
            var node = list.Find(3);
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
            Assert.IsFalse(list.Contains(2));
            Assert.IsFalse(list.Contains(3));
            Assert.IsTrue(list.Contains(1));
        }
        [TestMethod]
        public void TestForeach()
        {
            //Assign
            MyLinkedList<int> list = new MyLinkedList<int>();
            int localCount = 0;
            
            //Act
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            //Assert
            foreach (var item in list)
            {
                localCount++;
            }
            Assert.AreEqual(localCount, list.Count());
            Assert.AreNotEqual(1, localCount);
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
            Assert.AreEqual(6, list.Count());
            Assert.AreNotEqual(5, list.Count());
        }
        [TestMethod]
        public void TestAddString()
        {
            //Assign
            MyLinkedList<string> list = new MyLinkedList<string>();

            //Act
            list.AddLast("2");
            list.AddLast("pootIs");
            list.AddLast("åäö");
            list.AddFirst("8");

            //Assert
            Assert.AreEqual(true, list.Contains("åäö"));
            Assert.AreEqual(4, list.Count());
            Assert.AreEqual(true, list.Contains("8"));
            Assert.AreEqual(true, list.Contains("pootIs"));
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
            //Assert
            Assert.AreEqual(3, list.Count());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => list[10]);
            Assert.AreEqual(2, list[0].Data);
            Assert.AreEqual(3, list[1].Data);
            Assert.AreEqual(4, list[2].Data);
        }
    }
}