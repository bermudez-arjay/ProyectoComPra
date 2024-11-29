using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompra.ArbolesBinarios
{
    public class ArbolBinario
    {
        private NodoArbol raiz;

        public ArbolBinario()
        {
            raiz = null;
        }
        public void Insertar(int claveInsertar)
        {
            if (raiz == null) raiz = new NodoArbol(claveInsertar);
            else Insertar(claveInsertar, raiz);
        }
        private void Insertar(int dato, NodoArbol nodo)
        {
            if (dato < nodo.Dato)
            {
                if (nodo.Izquierdo == null) nodo.Izquierdo = new NodoArbol(dato);
                else Insertar(dato, nodo.Izquierdo);
            }
            else
            {
                if (nodo.Derecho == null) nodo.Derecho = new NodoArbol(dato);
                else Insertar(dato, nodo.Derecho);
            }
        }
        public void Eliminar(int dato)
        {
            raiz = EliminarNodo(raiz, dato);
        }
        private NodoArbol EliminarNodo(NodoArbol nodo, int dato)
        {
            if (nodo == null) return nodo;

            if (dato < nodo.Dato)
                nodo.Izquierdo = EliminarNodo(nodo.Izquierdo, dato);
            else if (dato > nodo.Dato)
                nodo.Derecho = EliminarNodo(nodo.Derecho, dato);
            else
            {
                if (nodo.Izquierdo == null)
                    return nodo.Derecho;
                else if (nodo.Derecho == null)
                    return nodo.Izquierdo;

                nodo.Dato = EncontrarMinimo(nodo.Derecho).Dato;
                nodo.Derecho = EliminarNodo(nodo.Derecho, nodo.Dato);
            }
            return nodo;
        }
        private NodoArbol EncontrarMinimo(NodoArbol nodo)
        {
            while (nodo.Izquierdo != null)
                nodo = nodo.Izquierdo;
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
