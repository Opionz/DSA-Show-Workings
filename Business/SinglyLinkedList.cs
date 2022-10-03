using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class SinglyLinkedList<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }

        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;
        public void AddFirst(T value)
        {
            AddFirst( new Node<T>(value));
        }

        private void AddFirst(Node<T> node)
        {
            // Save the current head
            Node<T> temp = Head;

            Head = node;

            // Shifting the former head
            Head.Next = temp;

            Count++;

            if (Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddLast(T value)
        {
            AddLast(new Node<T>(value));
        }

        private void AddLast(Node<T> node)
        {
            if (IsEmpty)
            {
                Head = node;
                Tail = Head;
            }
            else
            {
                Tail.Next = node;
            }
            Count++;
        }

        public void RemoveFirst()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }

            Head = Head.Next;
            if (Count == 1)
            {
                Tail = null;
            }
            Count--;
        }

        public void RemoveLast()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }

            if (Count == 1)
            {
                Head = Tail = null;
            }
            else
            {
                // WE NEED TO FIND THE PENULTIMATE NODE
                var current = Head;
                while(current.Next != Tail)
                {
                    current = current.Next;
                }

                // We will set the penultimate node's pointer to null
                current.Next = null;
                Tail = current;
            }
            Count--;
        }

    }
}
