using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM
{
    public class Enlace
    {

        /// <summary>
        ///  Constructor de Enlace inicializa la clase
        /// </summary>
        public Enlace(int peso, Nodo NodoA, Nodo NodoB)
        {
            this.Peso = peso;
            this.NodoA = NodoA;
            this.NodoB = NodoB;
        }

        /// <summary>
        ///  Constructor de Enlace inicializa la clase
        /// </summary>
        public Enlace()
        {
            this.Peso = 0;
            this.NodoA = null;
            this.NodoB = null;
        }

        public Nodo NodoB { get; set; }

        public Nodo NodoA { get; set; }

        public int Peso { get; set; }
       
        /// <summary>
        /// Devuelve el nodo no visitado
        /// </summary>
        /// <returns>Nodo no visitado</returns>
        public Nodo GetNodoNoVisitado() 
        {
            if (this.NodoA.visitado)
                return this.NodoB;
            return this.NodoA;
        }

        /// <summary>
        /// Develueve true si ambos nodos estan visitados.
        /// </summary>
        /// <returns> true si ambos nodos estan visitados</returns>
        public bool NodosVisitados()
        {
            return (this.NodoA.visitado && this.NodoB.visitado);
        }

        /// <summary>
        /// Devuelve el otro nodo, a partir de un nodo por parametro.
        /// </summary>
        /// <param name="n1">Nodo conocido</param>
        /// <returns>Otro nodo del enlace</returns>

        public Nodo GetOtroNodo(Nodo n1)
        {
             if (this.NodoA == n1)
                return this.NodoB;
             if (this.NodoB == n1)
                 return this.NodoA;
            return null;
        }
    }

    /// <summary>
    /// Clase que implementa IComparer para poder utilizar el objeto Enlace en las colecciones y algoritmos de ordenamiento de C#
    /// </summary>
    public class ComparadorDeEnlaces : IComparer<Enlace> 
    {
        public int Compare(Enlace x, Enlace y)
        {
            return (x.Peso.CompareTo(y.Peso));
        }
    }
    

}
