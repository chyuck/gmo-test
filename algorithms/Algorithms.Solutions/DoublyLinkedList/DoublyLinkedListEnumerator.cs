using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Solutions.DoublyLinkedList
{
    public class DoublyLinkedListEnumerator<T> : IEnumerator<T>
    {
        private readonly DoublyLinkedListNode<T> _first;
        private DoublyLinkedListEnumeratorStatus _status = DoublyLinkedListEnumeratorStatus.New;
        private DoublyLinkedListNode<T> _current;
        
        public DoublyLinkedListEnumerator(DoublyLinkedListNode<T> first)
        {
            _first = first;
        }

        private static DoublyLinkedListEnumeratorStatus GetStatusAfterMovingNext(DoublyLinkedListNode<T> current)
        {
            var hasNodes = current != null;
            
            return hasNodes ? DoublyLinkedListEnumeratorStatus.HasValue : DoublyLinkedListEnumeratorStatus.ReachedTheEnd;
        }

        public bool MoveNext()
        {
            switch (_status)
            {
                case DoublyLinkedListEnumeratorStatus.New:
                {
                    _current = _first;
                    _status = GetStatusAfterMovingNext(_current);
                    return _status == DoublyLinkedListEnumeratorStatus.HasValue;
                }

                case DoublyLinkedListEnumeratorStatus.HasValue:
                {
                    _current = _current.Next;
                    _status = GetStatusAfterMovingNext(_current);
                    return _status == DoublyLinkedListEnumeratorStatus.HasValue;
                }
                
                case DoublyLinkedListEnumeratorStatus.ReachedTheEnd:
                    return false;
            }
            
            throw new InvalidOperationException("Unknown status");
        }

        public void Reset()
        {
            _current = null;
            _status = DoublyLinkedListEnumeratorStatus.New;
        }

        public T Current 
        {
            get 
            {

                switch (_status)
                {
                    case DoublyLinkedListEnumeratorStatus.New:
                        throw new InvalidOperationException("Current is not initialized, call MoveNext.");
                    case DoublyLinkedListEnumeratorStatus.HasValue:
                        return _current.Value;
                    case DoublyLinkedListEnumeratorStatus.ReachedTheEnd:
                        throw new InvalidOperationException("Current has reached the end of the linked list.");
                }    
                
                throw new InvalidOperationException("Unknown status");
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose() { }
    }
}