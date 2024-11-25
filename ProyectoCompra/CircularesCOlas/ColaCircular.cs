using System;

namespace ProyectoCompra.CircularesCOlas
{
    public class ColaCircular<T>
    {
        private T[] _elementos;
        private int _frente;
        private int _final;
        private int _cantidad;

        public ColaCircular(int tamaño)
        {
            if (tamaño <= 0)
                throw new ArgumentException("El tamaño de la cola debe ser mayor a cero.");

            _elementos = new T[tamaño];
            _frente = -1;
            _final = -1;
            _cantidad = 0;
        }

        public int Cantidad => _cantidad;
        public int Tamaño => _elementos.Length;

        public bool EstaLlena => _cantidad == _elementos.Length;
        public bool EstaVacia => _cantidad == 0;


        public void Encolar(T elemento)
        {
            if (EstaLlena)
            {
                throw new InvalidOperationException("La cola está llena. No se puede encolar más elementos.");
            }

            if (_frente == -1)
                _frente = 0;

            _final = (_final + 1) % _elementos.Length;
            _elementos[_final] = elemento;
            _cantidad++;
        }

        public T Desencolar()
        {
            if (EstaVacia)
            {
                throw new InvalidOperationException("La cola está vacía. No se puede desencolar ningún elemento.");
            }

            T elemento = _elementos[_frente];
            _elementos[_frente] = default;
            _frente = (_frente + 1) % _elementos.Length;
            _cantidad--;

            if (_cantidad == 0)
            {
                _frente = -1;
                _final = -1;
            }

            return elemento;
        }

        public void AgregarAlInicio(T elemento)
        {
            if (EstaLlena)
            {
                throw new InvalidOperationException("La cola está llena. No se puede agregar más elementos al inicio.");
            }

            _frente = (_frente - 1 + _elementos.Length) % _elementos.Length;
            _elementos[_frente] = elemento;
            if (_final == -1)
                _final = _frente;

            _cantidad++;
        }

        public T EliminarDelFinal()
        {
            if (EstaVacia)
            {
                throw new InvalidOperationException("La cola está vacía. No se puede eliminar un elemento del final.");
            }

            T elemento = _elementos[_final];
            _elementos[_final] = default;
            _final = (_final - 1 + _elementos.Length) % _elementos.Length;
            _cantidad--;

            if (_cantidad == 0)
            {
                _frente = -1;
                _final = -1;
            }

            return elemento;
        }

        public T[] ConvertirAArray()
        {
            T[] resultado = new T[_cantidad];
            for (int i = 0; i < _cantidad; i++)
            {
                resultado[i] = _elementos[(_frente + i) % _elementos.Length];
            }
            return resultado;
        }
    }

}
