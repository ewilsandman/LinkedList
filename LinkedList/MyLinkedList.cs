﻿using System;

namespace MyLinkedList
{
    public class MyLinkedList<T>
    {
        private Node<T> first = null;
        public int Count
        {
            get;
            private set;
        } = 0;

        public Node<T> AddFirst(T data)
        {
            var node = new Node<T>(data);
            node.Next = first;
            first = node;
            Count++;
            return node;
        }

        public bool Contains(T data)
        {
            var current = first;
            while (current.Next != null)
            {
                if (current.Data.Equals(data))
                    return true;

                current = current.Next;
            }

            return false;
        }
        public Node<T> AddLast(T data)
        {
            var node = new Node<T>(data);
            return node;
        }
        public void Clear(T data)
        {
            var node = new Node<T>(data);
            node.Next = null;
        }
        public Node<T> Find(T data)
        {
            var node = new Node<T>(data);
            return node;
        }
        /*public Node<T> RemoveNode(Node n)
        {
            var node = new Node<T>(data);
            return node;
        }*/
        public Node<T> Remove(T data)
        {
            var node = new Node<T>(data);
            return node;
        }
        /*GetEnumerator()
        {

        }*/
    }

    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node(T data)
        {
            Data = data;
        }
    }
}
