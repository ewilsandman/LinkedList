using System;
using System.Collections;
using System.Collections.Generic;
namespace MyLinkedList
{
    public class MyLinkedList<T>
    {
        public Node<T> head = null;

        public int Count()
        {
            int count = 0;
            if (head == null)
            {
                return count;
            }
            else
            {
                count++;
                return head.Count(count);
            }
        }
        public void AddFirst(T data)
        {
            if(head == null)
            {
                head = new Node<T>(data);
            }
            else
            {
                var newNode = new Node<T>(data);
                newNode.Next = head.Next;
                head.Next = newNode;
            }
        }
        public void AddLast(T data)
        {
            if(head == null)
            {
                head = new Node<T>(data);
            }
            else
            {
                head.AddLast(data);
            }
        }
        public void Clear()
        {
            if (head != null)
            {
                head = null;
            }
        }
        public bool Contains(T data)
        {
            if (head == null)
            {
                return false;
            }
            if (head.Data.Equals(data))
            {
                return true;
            }
            if (head.Next != null)
            {
                return head.Next.Contains(data);
            }
            else
            {
                return false;
            }
        }
    }
    public class Node<T>
    {
        public int Count(int count)
        {
            if (Next == null)
            {
                return count;
            }
            else
            {
                count++;
                return Next.Count(count);
            }
        }
        public void AddLast(T data)
        {
            if (Next == null)
            {
                Next = new Node<T>(data);
            }
            else
            {
                Next.AddLast(data);
            }
        }
        public bool Contains(T data)
        {
            if (Data.Equals(data))
                return true;

            if (Next != null)
            {
                return Next.Contains(data);
            }
            else
            {
                return false;
            }
        }
       /* public int Find(T data)
        {
            
        }
        public void Remove(Node T)
        {

        }
        public void Remove(T data)
        {

        }*/
        public void GetEnumerator()
        {

        }
        public T Data { get; set; }
        public Node<T> Next { get; set; } = null;
        public Node(T data)
        {
            Data = data;
        }
    }
}
