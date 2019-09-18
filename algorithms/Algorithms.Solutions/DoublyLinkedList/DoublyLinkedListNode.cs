namespace Algorithms.Solutions.DoublyLinkedList
{
    public class DoublyLinkedListNode<T>
    {
        public DoublyLinkedListNode(T value)
        {
            Value = value;
        }

        public T Value { get; }

        public DoublyLinkedListNode<T> Previous { get; set; }
        public DoublyLinkedListNode<T> Next { get; set; }
    }
}