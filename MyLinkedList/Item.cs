namespace MyLinkedList
{
    internal class Item<T>
    {
        private T data = default;
        public Item<T> Next { get; set; }

        public T Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value ?? default;
            }
        }
        public Item(T data)
        {
            Data = data;
        }

        public static bool operator >(Item<T> item1, Item<T> item2)
        {
            if (int.Parse(item1.Data.ToString()) > int.Parse(item2.Data.ToString()))
            {
                return true;
            }
            return false;
        }
        public static bool operator <(Item<T> item1, Item<T> item2)
        {
            if (int.Parse(item1.Data.ToString()) < int.Parse(item2.Data.ToString()))
            {
                return true;
            }
            return false;
        }
        public static Item<int> operator +(Item<T> item1, Item<T> item2)
        {
            return new Item<int>(int.Parse(item1.Data.ToString()) + int.Parse(item2.Data.ToString()));
        }
        public static Item<int> operator -(Item<T> item1, Item<T> item2)
        {
            return new Item<int>(int.Parse(item1.Data.ToString()) - int.Parse(item2.Data.ToString()));
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
