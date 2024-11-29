using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompra.ArbolesAVL
{
    public class ArbolAVL
    {
        private NodoArbol raiz;

        public ArbolAVL()
        {
            raiz = null;
        }
        private NodoArbol RotacionIzquierda(NodoArbol nodo)
        {
            NodoArbol nuevoRaiz = nodo.Derecho;
            nodo.Derecho = nuevoRaiz.Izquierdo;
            nuevoRaiz.Izquierdo = nodo;

            nodo.FactorEquilibrio = CalcularFactorEquilibrio(nodo);
            nuevoRaiz.FactorEquilibrio = CalcularFactorEquilibrio(nuevoRaiz);

            return nuevoRaiz;
        }
        private NodoArbol RotacionDerecha(NodoArbol nodo)
        {
            NodoArbol nuevoRaiz = nodo.Izquierdo;
            nodo.Izquierdo = nuevoRaiz.Derecho;
            nuevoRaiz.Derecho = nodo;

            nodo.FactorEquilibrio = CalcularFactorEquilibrio(nodo);
            nuevoRaiz.FactorEquilibrio = CalcularFactorEquilibrio(nuevoRaiz);

            return nuevoRaiz;
        }
        public void Insertar(int claveInsertar)
        {
            raiz = Insertar(claveInsertar, raiz);
        }
        private NodoArbol Insertar(int dato, NodoArbol nodo)
        {
            if (nodo == null)
            {
                return new NodoArbol(dato);
            }

            if (dato < nodo.Dato)
            {
                nodo.Izquierdo = Insertar(dato, nodo.Izquierdo);
            }
            else
            {
                nodo.Derecho = Insertar(dato, nodo.Derecho);
            }

            nodo.FactorEquilibrio = CalcularFactorEquilibrio(nodo);
            return Balancear(nodo);
        }
        private NodoArbol Balancear(NodoArbol nodo)
        {
            if (nodo.FactorEquilibrio > 1)
            {
                if (CalcularFactorEquilibrio(nodo.Izquierdo) < 0)
                    nodo.Izquierdo = RotacionIzquierda(nodo.Izquierdo);

                nodo = RotacionDerecha(nodo);
            }
            else if (nodo.FactorEquilibrio < -1)
            {
                if (CalcularFactorEquilibrio(nodo.Derecho) > 0)
                    nodo.Derecho = RotacionDerecha(nodo.Derecho);

                nodo = RotacionIzquierda(nodo);
            }

            return nodo;
        }
        private int CalcularFactorEquilibrio(NodoArbol nodo)
        {
            if (nodo == null)
                return 0;

            return ObtenerAltura(nodo.Izquierdo) - ObtenerAltura(nodo.Derecho);
        }
        private int ObtenerAltura(NodoArbol nodo)
        {
            if (nodo == null)
                return 0;

            return 1 + Math.Max(ObtenerAltura(nodo.Izquierdo), ObtenerAltura(nodo.Derecho));
        }
        public void Eliminar(int dato)
        {
            raiz = EliminarNodo(raiz, dato);
        }
        private NodoArbol EliminarNodo(NodoArbol nodo, int dato)
        {
            if (nodo == null)
                return nodo;

            if (dato < nodo.Dato)
            {
                nodo.Izquierdo = EliminarNodo(nodo.Izquierdo, dato);
            }
            else if (dato > nodo.Dato)
            {
                nodo.Derecho = EliminarNodo(nodo.Derecho, dato);
            }
            else
            {
                if (nodo.Izquierdo == null)
                    return nodo.Derecho;
                else if (nodo.Derecho == null)
                    return nodo.Izquierdo;

                nodo.Dato = EncontrarMinimo(nodo.Derecho).Dato;
                nodo.Derecho = EliminarNodo(nodo.Derecho, nodo.Dato);
            }

            nodo.FactorEquilibrio = CalcularFactorEquilibrio(nodo);
            return Balancear(nodo);
        }
        private NodoArbol EncontrarMinimo(NodoArbol nodo)
        {
            while (nodo.Izquierdo != null)
            {
                nodo = nodo.Izquierdo;
            }

            return nodo;
        }
        public string ObtenerRecorridoPreorden()
        {
            var recorrido = new List<int>();
            RecorridoPreorden(raiz, recorrido);
            return string.Join(", ", recorrido);
        }
        private void RecorridoPreorden(NodoArbol nodo, List<int> recorrido)
        {
            if (nodo != null)
            {
                recorrido.Add(nodo.Dato);
                RecorridoPreorden(nodo.Izquierdo, recorrido);
                RecorridoPreorden(nodo.Derecho, recorrido);
            }
        }
        public string ObtenerRecorridoInorden()
        {
            var recorrido = new List<int>();
            RecorridoInorden(raiz, recorrido);
            return string.Join(", ", recorrido);
        }
        private void RecorridoInorden(NodoArbol nodo, List<int> recorrido)
        {
            if (nodo != null)
            {
                RecorridoInorden(nodo.Izquierdo, recorrido);
                recorrido.Add(nodo.Dato);
                RecorridoInorden(nodo.Derecho, recorrido);
            }
        }
        public string ObtenerRecorridoPosorden()
        {
            var recorrido = new List<int>();
            RecorridoPosorden(raiz, recorrido);
            return string.Join(", ", recorrido);
        }
        private void RecorridoPosorden(NodoArbol nodo, List<int> recorrido)
        {
            if (nodo != null)
            {
                RecorridoPosorden(nodo.Izquierdo, recorrido);
                RecorridoPosorden(nodo.Derecho, recorrido);
                recorrido.Add(nodo.Dato);
            }
        }
    }
}
