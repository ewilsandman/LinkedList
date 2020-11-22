using System;
using System.Collections;
using System.Collections.Generic;
namespace MyLinkedList
{
    public class MyLinkedList<T>: IEnumerable<T>
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
        public Node<T> FindNode(T data)
        {
            if (head == null)
            {
                return null;
            } 
            if (Equals(head.Data, data))
            {
                return head;
            }
            if (head.Next == null)
            {
                return null;
            }
            else if (Equals(head.Next.Data, data))
            {
                return head.Next;
            }
            else
            {
                return head.Next.Find(data);
            }
        }
        public bool Remove(T data)
        {
            if (head == null)
            {
                return false;
            }
            else if (Equals(head.Data, data))
            {
                head = head.Next;
                return true;
            }
            if (head.Next == null)
            {
                return false;
            }
            else if (Equals(head.Next.Data, data)) 
            {
                head.Next = head.Next.Next;
                return true;
            }
            else
            {
               return head.Next.Remove(data);
            }
        }
        public void Remove(Node<T> toRemove)
        {
            if (head == null)
            {
                return;
            }
            else if (head == toRemove)
            {
                head = head.Next;
            }
            if (head.Next == null)
            {
                return;
            }
            else if (head.Next == toRemove)
            {
                head.Next = head.Next.Next;
            }
            else
            {
                head.Next.Remove(toRemove);
            }
        }
        public Node<T> this[int index]
        {
            get => FindByIndex(index);
            //set => FindByIndex(index) = value;
        }
        
        private Node<T> FindByIndex(int index)
        {
        int localCount = 0;
            if (head == null)
            {
                return null;
            }
            else if (localCount == index)
            {
                return head;
            }
            if(head.Next != null)
            {
                if (localCount++ == index) 
                {
                    return head.Next;
                }
                else
                {
                    head.Next.FindByIndex(index, localCount);
                }
            }
            return null;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new ListEnum<T>(this);
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
            {
                return true;
            }
            if (Next != null)
            {
                return Next.Contains(data);
            }
            else
            {
                return false;
            }
        }
    public Node<T> FindByIndex(int index, int localCount)
        {   if (Next != null)
            {
                if (localCount++ == index)
                {
                    return Next;
                }
                else
                {
                    localCount++;
                    return Next.FindByIndex(index, localCount);
                }
            }
        else
            {
                return null;
            }
        }
        public Node<T> Find(T data)
        {
            if (Next == null)
            {
                return null;
            }
            else if (Equals(Next.Data, data))
            {
                return Next;
            }
            else
            {
                return Next.Find(data);
            }
        }
        public void Remove(Node<T> toRemove)
        {
            if (Next != null)
            {
                if (Next == toRemove)
                {
                    Next = Next.Next;
                }
                else
                {
                    Next.Remove(toRemove);
                }
            }
             
        }
        public bool Remove(T data)
        {
            if (Next != null)
            {
                if (Equals(Next.Data, data))
                {
                    Next = Next.Next;
                    return true;
                }
                else
                {
                  return Next.Remove(data);
                }
            }
            else
            {
                return false;
            }
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; } = null;
        public Node(T data)
        {
            Data = data;
        }
    }
}
