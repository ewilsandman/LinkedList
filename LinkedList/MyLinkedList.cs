using System;
using System.Collections;
using System.Collections.Generic;
namespace MyLinkedList
{
    public class MyLinkedList<T>: IEnumerable<T>
    {
        public Node<T> head = null;
        public class ListEnum : IEnumerator<T>
        {
            MyLinkedList<T> list;
            int position = -1;

            public void IEnumerator(MyLinkedList<T> list)
            {
                this.list = list;
            }
            public bool MoveNext()
            {
                return ++position < list.Count;
            }

            public void Reset()
            {
                position = -1;
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public T current
            {
                get
                {
                    if(position == -1)
                        {
                        throw new InvalidOperationException();
                        }
                    return list[position];
                }
            }

            public T Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();
        }
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
            else if (Equals(head.Next.Data, data)) 
            {
                head.Next = head.Next.Next;
                return true;
            }
            else
            {
                head.Next.Remove(data);
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
            set => Dummy[index] = value;
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
                    head.Next.Remove(data);
                }
            }
            return null;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)ListEnum();
        }
        public IEnumerator<T> GetEnumerator()
        {
           GetEnumerator();
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
                    Next.FindByIndex(index, localCount);
                }
            }        }
        public Node<T> Find(T data)
        {
            if (Equals(Next.Data, data))
            {
                return Next;
            }
            else if (Next == null)
            {
                return null;
            }
            else
            {
                return Next.Find(data);
            }
        }
        public bool Remove(Node<T> toRemove)
        {
            if (Next != null)
            {
                if (Next == toRemove)
                {
                    Next = Next.Next;
                    return true;
                }
                else
                {
                    Next.Remove(toRemove);
                }
            }
            else
            {
                return false;
            }
        }
        public void Remove(T data)
        {
            if (Next != null)
            {
                if (Equals(Next.Data, data))
                {
                    Next = Next.Next;
                }
                else
                {
                    Next.Remove(data);
                }
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
