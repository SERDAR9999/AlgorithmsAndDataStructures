using System.Collections;

namespace LinkedList
{
    /// <summary>
    /// Linked List.
    /// </summary>
    public class MyLinkedList<T> : IEnumerable
    {
        /// <summary>
        /// The first item in the list.
        /// </summary>
        public Item<T> Head { get; private set; }

        /// <summary>
        /// The last item in the list.
        /// </summary>
        public Item<T> Tail { get; private set; }

        /// <summary>
        /// Count of items in the list.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Create empty list.
        /// </summary>
        public MyLinkedList()
        {
            EmptyList();
        }

        private void EmptyList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        /// <summary>
        /// Create list with first item.
        /// </summary>
        /// <param name="data">Data of the first item.</param>
        public MyLinkedList(T data)
        {
            var item = new Item<T>(data);
            SetHeadAndTail(item);
        }

        private void SetHeadAndTail(Item<T> item)
        {
            Head = item;
            Tail = item;
            Count = 1;
        }

        /// <summary>
        /// Add an item to the end of the list.
        /// </summary>
        /// <param name="data">Item data.</param>
        public void Add(T data)
        {
            var item = new Item<T>(data);
            if (Tail != null)
            {
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else SetHeadAndTail(item);
        }

        /// <summary>
        /// Delete an item from the list.
        /// </summary>
        /// <param name="data">Item data.</param>
        public void Delete(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head.Next;
                var previous = Head;

                for (var i = 1; i < Count; i++)
                {
                    if (data.Equals(current.Data))
                    {
                        if (current == Tail)
                        {
                            Tail = previous;
                            previous.Next = null;
                        }
                        else previous.Next = current.Next;

                        Count--;
                        return;
                    }

                    if (i != Count - 1)
                    {
                        previous = current;
                        current = current.Next;
                    }
                }
            }
        }

        /// <summary>
        /// Clear the list.
        /// </summary>
        public void Clear()
        {
            EmptyList();
        }

        /// <summary>
        /// Add an item to the start of the list.
        /// </summary>
        /// <param name="data">Item data.</param>
        public void AppendHead(T data)
        {
            var item = new Item<T>(data);
            if (Head != null)
            {
                item.Next = Head;
                Head = item;
                Count++;
            }
            else SetHeadAndTail(item);
        }

        /// <summary>
        /// Insert an item after another item.
        /// </summary>
        /// <param name="target">The item after which you want to insert another item.</param>
        /// <param name="data">Item data.</param>
        public void InsertAfter(T target, T data)
        {
            var item = Head;

            for (var i = 0; i < Count; i++)
            {
                if (target.Equals(item.Data))
                {
                    var newItem = new Item<T>(data);
                    newItem.Next = item.Next;
                    item.Next = newItem;

                    Count++;
                    return;
                }

                if (i != Count - 1) item = item.Next;
            }
        }

        /// <summary>
        /// Get an enumeration of all the list items.
        /// </summary>
        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public override string ToString()
        {
            return $"Linked List {Count} items";
        }

    }
}
