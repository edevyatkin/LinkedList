using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomLinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {

        internal Node<T> Head { get; set; }

        public LinkedList()
        {

        }

        public LinkedList(params T[] values) => Array.ForEach(values, v => Insert(v));

        private Node<T> Insert(Node<T> node)
        {
            node.Next = Head;
            Head = node;
            return Head;
        }

        public Node<T> Insert(T value) => Insert(new Node<T>(value));

        public void Reverse()
        {
            if (Head == null)
                return;
            if (Head.Next == null)
                return;

            Node<T> prev = null;
            Node<T> current = Head;

            do {
                var next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            } while (current != null);

            Head = prev;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next { get; set; }

            public Node(T value)
            {
                Value = value;
            }
        }
    }
}
