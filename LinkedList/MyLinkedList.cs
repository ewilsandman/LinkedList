using System;
using System.Collections;
using System.Collections.Generic;
namespace MyLinkedList
{
    public class MyLinkedList<T>: IEnumerable<Node<T>>
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
            /*
            InvalidOperationException
            node belongs to another LinkedList<T>.
            Kan inte implementera
            */
        }
        public void AddLast(T data)
        {
            if (head == null)
            {
                head = new Node<T>(data);
            }
            else
            {
                head.AddLast(data);
            }
            /*
            InvalidOperationException
            node belongs to another LinkedList<T>.
            Kan inte implementera
            */
        }
        public void Clear()
        {
        head = null;
            
            /*NotSupportedException
            The ICollection<T> is read-only.
            kan inte implementera
            */
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
        public Node<T> Find(T data)
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
            if (toRemove == null)
            {
                throw new ArgumentNullException("toRemove" ,"Node is null");
            }
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
            /*
            ArgumentNullException
            node is null.
            InvalidOperationException
            node belongs to another LinkedList<T>.
            */
        }
        public Node<T> this[int index]
        {
            get => FindByIndex(index);
        }
        
        private Node<T> FindByIndex(int index)
        {
            int localCount = 0;
            if (head == null)
            {
                throw new ArgumentOutOfRangeException("index" ,"list is empty");
            }
            else if (index ==0)
            {
                return head;
            }
            if (index > Count()-1)
            {
                throw new ArgumentOutOfRangeException("index" ,"index is out of range");
            }
            Node<T> tempnode = head;
            while (localCount != index)
            {
                localCount++;
                tempnode = tempnode.Next;
            }
            return tempnode;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<Node<T>> GetEnumerator()
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
            else
            {
                throw new InvalidOperationException("Node is not in list");
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
