using System.Collections;

namespace MyLinkedList
{
    internal class MyLinkedList<T> : IEnumerable
    {
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set; }
        public int Count { get; private set; }
        public int this[string index]
        {
            get
            {
                int count = 0;
                Item<T> current = Head.Next;
                Item<T> previous = Head;
                bool presence = false;
                for (int i = 0; i < Count; i++)
                {
                    if (previous.Data.ToString() == index)
                    {
                        presence = true;
                        break;
                    }
                    count++;
                    previous = current;
                    current = current.Next;
                }
                if (presence)
                {
                    return count;
                }
                else
                {
                    return -1;
                }
            }
        }

        public MyLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public MyLinkedList(MyLinkedList<T> myLinkedList)
        {
            Head = myLinkedList.Head;
            Tail = myLinkedList.Tail;
            Count = myLinkedList.Count;
        }
        public MyLinkedList(T data)
        {
            SetHeadAndTail(data);
        }
        public void Add(T data)
        {
            if (Tail == null)
            {
                SetHeadAndTail(data);
            }
            else
            {
                Item<T> item = new(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
        }
        public void AddBefore(T data, T newItem)
        {
            Item<T> item = new(newItem);
            Item<T> current = Head.Next;
            Item<T> previous = Head;
            if (Head.Data.Equals(data))
            {
                Head = item;
                Head.Next = previous;
                Count++;
                return;
            }
            while (current != null)
            {
                if (previous.Data.Equals(data))
                {
                    Head.Next = item;
                    Head.Next.Next = previous;
                    Count++;
                    return;
                }
                previous = current;
                current = current.Next;
            }
        }
        public void AddAfter(T data, T newItem)
        {
            Item<T> item = new(newItem);
            Item<T> current = Head.Next;
            Item<T> previous = Head;
            if (Head.Data.Equals(data))
            {
                Head.Next = item;
                Head.Next.Next = current;
                Count++;
                return;
            }
            while (current != null)
            {
                if (previous.Data.Equals(data))
                {
                    previous.Next = item;
                    previous.Next.Next = current;
                    Count++;
                    return;
                }
                previous = current;
                current = current.Next;
            }
        }
        public void Remove(T data)
        {
            if (Head == null)
            {
                return;
            }
            else
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }
                Item<T> current = Head.Next;
                Item<T> previous = Head;
                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }
                    previous = current;
                    current = current.Next;
                }
            }

        }

        public void RecRemoveIndex(int index)
        {
            if (index >= Count)
            {
                return;
            }
            if (index == 0)
            {
                Head = Head.Next;
                Count--;
                return;
            }
            Item<T> current = Head.Next;
            Item<T> previous = Head;
            RecRemove(current, previous, index);
        }
        private void RecRemove(Item<T> current, Item<T> previous, int index)
        {
            if (index == 1)
            {
                previous.Next = current.Next;
                Count--;
                return;
            }
            index--;
            previous = current;
            current = current.Next;
            RecRemove(current, previous, index);
        }
        public static void RemoveAllNegative(MyLinkedList<int> list)
        {
            foreach (int item in list)
            {
                if (item < 0)
                {
                    list.Remove(item);
                }
            }
        }

        public void PrintIntegers()
        {
            Printer(Head.Next, Head);
        }
        private int counter = 0;
        private void Printer(Item<T> current, Item<T> previous)
        {
            if (counter == Count - 1)
            {
                if (int.TryParse(previous.Data.ToString(), out int _))
                {
                    Console.WriteLine(previous);
                }
                return;
            }
            counter++;
            if (int.TryParse(previous.Data.ToString(), out int _))
            {
                Console.WriteLine(previous);
            }
            previous = current;
            current = current.Next;
            Printer(current, previous);
        }

        public void SortByDescending()
        {
            for (int i = 0; i < Count; i++)
            {
                int count = 0;
                Item<T> current = Head.Next;
                Item<T> previous = Head;
                while (current != null && current.Next != null)
                {
                    if (int.Parse(current.Data.ToString()) > int.Parse(previous.Data.ToString()) ||
                        int.Parse(current.Next.Data.ToString()) > int.Parse(previous.Next.Data.ToString()))
                    {
                        if (count == 0)
                        {
                            Head = Head.Next;
                            Item<T> temp = Head.Next;
                            Head.Next = previous;
                            Head.Next.Next = temp;
                            count++;
                            previous = current;
                            current = current.Next;
                            continue;
                        }
                        if (int.Parse(current.Next.Data.ToString()) > int.Parse(previous.Next.Data.ToString()) && count != 0)
                        {
                            Item<T> temp = current;
                            Item<T> secTemp = current.Next.Next;
                            previous.Next = current.Next;
                            previous.Next.Next = temp;
                            if (temp == null)
                            {
                                continue;
                            }
                            previous.Next.Next.Next = secTemp;
                        }
                    }
                    previous = current;
                    if (current == null)
                    {
                        continue;
                    }
                    current = current.Next;
                }
            }
        }

        public Item<T> FindElement(T data)
        {
            Item<T> current = Head.Next;
            Item<T> previous = Head;
            bool finded = false;
            while (current != null)
            {
                if (previous.Data.Equals(data))
                {
                    finded = true;
                    break;
                }
                previous = current;
                if (current == null)
                {
                    break;
                }
                current = current.Next;
            }
            if (finded)
            {
                return previous;
            }
            return new Item<T>(default);
        }

        public int ProductionPozitives()
        {
            Item<T> current = Head.Next;
            Item<T> previous = Head;
            int product = 1;
            while (current != null)
            {
                if (int.Parse(previous.Data.ToString()) > 0)
                {
                    product *= int.Parse(previous.Data.ToString());
                }
                previous = current;
                current = current.Next;
            }
            return product;
        }

        private void SetHeadAndTail(T data)
        {
            Item<T> item = new(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public IEnumerator GetEnumerator()
        {
            Item<T> current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
