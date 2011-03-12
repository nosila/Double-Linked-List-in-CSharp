using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Double_Linked_List
{
    class DLL<E>
    {
        private Node<E> head;
        private Node<E> tail;

        public DLL()
        {
            this.head = null;
            this.tail = null;
        }

        public void AddFirst(E element)
        {
            Node<E> newNode = new Node<E>(element, next: head);
            if (head != null)
            {
                head.SetPrev(newNode);
                head = newNode;
            }
            else
            {
                head = newNode;
            }

            if (tail == null)
                tail = newNode;
        }

        public void AddLast(E element)
        {
            Node<E> newNode = new Node<E>(element, prev: tail);
            if (tail != null)
            {
                tail.SetNext(newNode);
                tail = newNode;
            }
            else
                tail = newNode;

            if (head == null)
                head = newNode;
        }

        override public string ToString()
        {
            Node<E> aux = head;
            string final = "<";
            while (aux != null)
            {
                final += aux.GetElement() + ";";
                aux = aux.GetNext();
            }

            return final + ">";
        }

        private class Node<E>
        {
            private E _element;
            private Node<E> _next;
            private Node<E> _prev;

            public Node(E element, Node<E> next = null, Node<E> prev = null)
            {
                this._element = element;
                this._next = next;
                this._prev = prev;
            }

            public Node<E> GetNext()
            {
                return this._next;
            }

            public Node<E> GetPrev()
            {
                return this._prev;
            }

            public E GetElement()
            {
                return this._element;
            }

            public void SetNext(Node<E> node)
            {
                this._next = node;
            }
            public void SetPrev(Node<E> node)
            {
                this._prev = node;
            }
            public void SetElement(E element)
            {
                this._element = element;
            }
        }
    }
}
