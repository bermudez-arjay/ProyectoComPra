<<<<<<< HEAD
=======
<<<<<<<< HEAD:ProyectoCompra/CircularesCOlas/CircularQueue.cs
>>>>>>> 24435b81521438c5429d4046db0dcb9d216746c6
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace ProyectoCompra.CircularesCOlas
=======
namespace ColasCirculares
>>>>>>> 24435b81521438c5429d4046db0dcb9d216746c6
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
<<<<<<< HEAD
        public int Capacity => _elements.Length;
    }
}
=======
        public int Capacity => _elements.Length; 
    }
}
========
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompra.CircularesCOlas
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
>>>>>>>> 24435b81521438c5429d4046db0dcb9d216746c6:ProyectoCompra/CircularesCOlas/QueueCircular.cs
>>>>>>> 24435b81521438c5429d4046db0dcb9d216746c6
