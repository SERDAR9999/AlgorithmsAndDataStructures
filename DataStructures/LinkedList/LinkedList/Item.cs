namespace LinkedList
{
    /// <summary>
    /// List item. 
    /// </summary>
    public class Item<T>
    {
        private T data = default(T);

        /// <summary>
        /// The next item after the current one.
        /// </summary>
        public Item<T> Next { get; set; }

        /// <summary>
        /// Data item.
        /// </summary>
        public T Data
        {
            get => data;
            set => data = value ?? throw new ArgumentNullException(nameof(value));
        }

        public Item(T data)
        {
            Data = data;
            Next = null;
        }

        public override string ToString() => Data.ToString();
    }
}
