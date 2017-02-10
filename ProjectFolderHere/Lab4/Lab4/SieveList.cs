using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class SieveList : IEnumerable<int>
    {
        private Node _head;
        private Node _tail;

        public void BuildList(int bound)
        {
            _head = new Lab4.SieveList.Node(2);
            _tail = _head;
            for (int i = 3; i <= bound; i++)
            {
                Add(i);
            }
        }

        public void Add(int val)
        {
            Node newNode = new Node(val);
            _tail.Next = newNode;
            _tail = newNode;
        }

        public void FindPrimes()
        {
            Node current = _head;
            while (current != null)
            {
                Node temp = current;
                while (temp.Next != null)
                {
                    if (temp.Next.Data % current.Data == 0)
                    {
                        temp.Next = temp.Next.Next;
                    }
                    temp = temp.Next;
                    if (temp == null) break;
                }
                current = current.Next;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new SieveEnumerator(_head);
            //throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
            //throw new NotImplementedException();
        }



        private class Node{
            private int _data;
            private Node _next;

            public Node(int d)
            {
                _data = d;
                _next = null;
            }

            public int Data
            {
                get
                {
                    return _data;
                }
                set
                {
                    _data = value;
                }
            }

            public Node Next
            {
                get
                {
                    return _next;
                }
                set
                {
                    _next = value;
                }
            }
       }

        private class SieveEnumerator : IEnumerator<int>
        {
            private Node _current;

            public SieveEnumerator(Node h)
            {
                _current = new Lab4.SieveList.Node(-1);
                _current.Next = h;
            }

            public int Current
            {
                get
                {
                    return _current.Data;
                    //throw new NotImplementedException();
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                    //throw new NotImplementedException();
                }
            }

            public void Dispose()
            {
                //throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                if (_current == null)
                    return false;
                else
                {
                    _current = _current.Next;
                    if (_current == null)
                        return false;
                    return true;
                }
                    
                //throw new NotImplementedException();
            }

            public void Reset()
            {
                //throw new NotImplementedException();
            }
        }
    }
}
