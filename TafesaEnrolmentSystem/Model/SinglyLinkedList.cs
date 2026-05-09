using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TafesaEnrolmentSystem
{
    public class SinglyLinkedList<T> : ICollection<T>
    {
        public SinglyLinkedListNode<T> Head { get; private set; }
        public SinglyLinkedListNode<T> Tail { get; private set; }
        public int Count { get; private set; }

        // insert at head
        public void AddFirst(T value)
        {
            AddFirst(new SinglyLinkedListNode<T>(value));
        }

        public void AddFirst(SinglyLinkedListNode<T> node)
        {
            node.Next = Head;
            Head = node;
            Count++;

            if (Count == 1)
            {
                Tail = Head;
            }
        }

        // insert at tail
        public void AddLast(T value)
        {
            AddLast(new SinglyLinkedListNode<T>(value));
        }

        public void AddLast(SinglyLinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }

            Tail = node;
            Count++;
        }

        // remove at head
        public void RemoveFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;
                Count--;

                if (Count == 0)
                {
                    Tail = null;
                }
            }
        }

        // remove at tail
        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    SinglyLinkedListNode<T> current = Head;

                    while (current.Next != Tail)
                    {
                        current = current.Next;
                    }

                    current.Next = null;
                    Tail = current;
                }

                Count--;
            }
        }

        public void Add(T item)
        {
            AddFirst(item);
        }

        public bool Contains(T item)
        {
            SinglyLinkedListNode<T> current = Head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            SinglyLinkedListNode<T> current = Head;

            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public bool Remove(T item)
        {
            SinglyLinkedListNode<T> previous = null;
            SinglyLinkedListNode<T> current = Head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                        {
                            Tail = previous;
                        }

                        Count--;
                    }
                    else
                    {
                        RemoveFirst();
                    }

                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }
 //T value
        public void Clear  ()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool IsReadOnly => false;

        // traverse
        public IEnumerator<T> GetEnumerator()
        {
            SinglyLinkedListNode<T> current = Head;

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

        // insert at any position in list

         public void InsertAtPosition(T value, int position)
         {
            // uses head or tail methods if position value is the first or last index position
            if (position == 0)
            {
                AddFirst(value);
            }

            else if (position == Count)
            {
                AddLast(value);
            }


            else
            {

                //traverse to position  in list (one before where new item to be inserted)
                SinglyLinkedListNode<T> current = Head;
                for (int i = 0; i < position - 1; i++)
                {
                    current = current.Next;
                }
                // add new node for new list item
                SinglyLinkedListNode<T> newNode = new SinglyLinkedListNode<T>(value);

                // new node is to point to where the previous node now points to (next item in list)
                newNode.Next = current.Next;
                // previous node to point to the newly inserted node
                current.Next = newNode;

                // update count of list items
                Count++;
            }
           

            



        }

      

    }
}