using System;
using System.Collections;
using System.Collections.Generic;

namespace MyLinkedList
{
    public class ListEnum<T> : IEnumerator<Node<T>>
    {
        private readonly MyLinkedList<T> list;
        private int position;

        public ListEnum(MyLinkedList<T> list)
        {
            this.list = list;
            position = -1;
        }
        public bool MoveNext()
        {
            if (list.head != null)
            {
                return ++position < list.Count();
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
            // This method is intentionally left empty
        }

        public Node<T> Current
        {
            get
            {
                if (position == -1)
                {
                    throw new InvalidOperationException();
                }
                return list[position];
            }
        }
        object IEnumerator.Current => Current;
    }
}
