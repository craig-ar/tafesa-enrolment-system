using System; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace TafesaEnrolmentSystem.Model
{
    internal class DoublyLinkedList<T> : ICollection<T>
    {
        

        public DoublyLinkedListNode<T> Head
        {
            get;
            private set;

        }
        public DoublyLinkedListNode<T> Tail
        {
            get;
            private set;
        }


        //public T Value { get; set; }



        public int Count
        {
            get; private set;
        }

        public void Add(T value)
        {
            AddFirst(new DoublyLinkedListNode<T>(value));
        }

        public void AddFirst(T value)
        {
            AddFirst(new DoublyLinkedListNode<T>(value));
        }
        public void AddFirst(DoublyLinkedListNode<T> node)

        {

            DoublyLinkedListNode<T> temp = Head;

            Head = node;

            Head.Next = temp;

            if (Count == 0)
            {

                Tail = Head;
            }
            else
            {
                temp.Previous = Head;
            }
            Count++;
        }
        public void AddLast(T value)
        {
            AddLast(new DoublyLinkedListNode<T>(value));
        }

        public void AddLast(DoublyLinkedListNode<T> node)
        {

            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
            }

            Tail = node;
            Count++;
        }

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
                else
                {
                    Head.Previous = null;
                }
            }
        }
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
                    Tail.Previous.Next = null;
                    Tail = Tail.Previous;
                }
                Count--;
            }
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            DoublyLinkedListNode<T> current = Head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                    return true;

                current = current.Next;
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            DoublyLinkedListNode<T> current = Head;

            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public bool Remove(T item)
        {
            DoublyLinkedListNode<T> previous = null;
            DoublyLinkedListNode<T> current = Head;

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

        public bool IsReadOnly => false;

        // traverse
        public IEnumerator<T> GetEnumerator()
        {
            DoublyLinkedListNode<T> current = Head;

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
                DoublyLinkedListNode<T> current = Head;
                for (int i = 0; i < position - 1; i++)
                {
                    current = current.Next;
                }
                // add new node for new list item
                DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(value);

                newNode.Next = current.Next;
                newNode.Previous = current;

                current.Next.Previous = newNode;
                current.Next = newNode;

                // update count of list items
                Count++;
            }
        }


    }
}
    
