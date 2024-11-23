using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasCirculares
{
    public class CircularQueue<T>
    {
        private T[] _elements;
        private int _front;
        private int _rear;
        private int _count;

        public CircularQueue(int size)
        {
            _elements = new T[size];
            _front = 0;
            _rear = -1;
            _count = 0;
        }

        public void Enqueue(T item)
        {
            if (_count == _elements.Length)
                throw new InvalidOperationException("La cola está llena");

            _rear = (_rear + 1) % _elements.Length;
            _elements[_rear] = item;
            _count++;
        }

        public T Dequeue()
        {
            if (_count == 0)
                throw new InvalidOperationException("La cola está vacía");

            var item = _elements[_front];
            _front = (_front + 1) % _elements.Length;
            _count--;
            return item;
        }

        public int Count => _count;
        public int Capacity => _elements.Length; 
    }
}
