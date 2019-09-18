using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Solutions.DoublyLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        private DoublyLinkedListNode<T> _firstNode;
        private DoublyLinkedListNode<T> _lastNode;
        
        public void AddValueToTheEnd(T value)
        {
            var node = new DoublyLinkedListNode<T>(value);
            
            // no nodes
            if (_lastNode == null)
            {
                _firstNode = _lastNode = node;
                return;
            }
            
            // at least one node exists
            node.Previous = _lastNode;
            _lastNode.Next = node;
            _lastNode = node;
        }

        public void RemoveValue(T value)
        {
            if (_firstNode == null)
                return;

            var current = _firstNode;
            while (current != null)
            {
                if (Equals(current.Value, value))
                {
                    RemoveNode(current);
                    return;
                }
               
                current = current.Next;
            }
        }

        private void RemoveNode(DoublyLinkedListNode<T> node)
        {
            if (node == null)
                throw new ArgumentNullException(nameof(node));
            
            // node is the only one in the linked list
            if (node.Previous == null && node.Next == null)
            {
                _firstNode = _lastNode = null;
                return;
            }

            // node is the first
            if (node.Previous == null)
            {
                node.Next.Previous = null;
                _firstNode = node.Next;
                return;
            }
            
            // node is the last
            if (node.Next == null)
            {
                node.Previous.Next = null;
                _lastNode = node.Previous;
                return;
            }
            
            // node in the middle of the linked list
            node.Next.Previous = node.Previous;
            node.Previous.Next = node.Next;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new DoublyLinkedListEnumerator<T>(_firstNode);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}