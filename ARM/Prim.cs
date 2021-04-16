using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM
{
    public static class Prim
    {
        public static List<Enlace> Ejecutar(Grafo g){
            List<Enlace> resultado = new List<Enlace>();         // Creo una nueva lista de enlaces 
            Nodo n = g.GetNodo();                                // Obtengo el primer nodo del grafo
            if (n != null)
            {                                                    // Si el grafo tiene nodos
                n.visitado = true;                               // Marco el nodo como visitado
                List<Enlace> enlaces = g.GetEnlaces(n);          // Obtengo todos los enlaces que contenga a n cuyo otro nodo 
                                                                 //   no este visitado
                while (!g.TodosVisitados())                      // Mientras no esten todos los nodos visitados
                {
                    var enlaceMenor = EnlaceMenorPeso(enlaces);  // Obtego el enlace de menor peso 
                    n = enlaceMenor.GetNodoNoVisitado();         // Obtengo el nodo no visitado del enlace
                    n.visitado = true;                           // Marco el nodo como visitado
                    enlaces.AddRange(g.GetEnlaces(n));           // Agrego a la lista de enlaces a visitar todos los enlaces 
                                                                 //    del nuevo nodo
                    enlaces = RemoverEnlaces(enlaces);           // Elimino todos los enlaces con los 2 nodos visitados 
                                                                 //    de la lista
                    resultado.Add(enlaceMenor);                  // Agrego el enlace menor a la lista de resultado
                }
            }
           
            return resultado;
        }

        /// <summary>
        /// Busca el enlace de menor peso de la lista
        /// </summary>
        /// <param name="enlaces"></param>
        /// <returns>Enlace de menor peso</returns>
        public static Enlace EnlaceMenorPeso(List<Enlace> enlaces) // 
        {   
            enlaces.Sort(new ComparadorDeEnlaces());
            return enlaces.FirstOrDefault();
        }

        /// <summary>
        /// Elimina los enlaces visitados
        /// </summary>
        /// <param name="enlaces">Lista de enlaces</param>
        /// <returns>Lista de enlaces sin visitados</returns>
        public static List<Enlace> RemoverEnlaces(List<Enlace> enlaces) 
        {
            List<Enlace> enlacesAux = new List<Enlace>() ;
            foreach (var e in enlaces)
            {
                if (!e.NodoA.visitado || !e.NodoB.visitado)
                    enlacesAux.Add(e);
            }

            return enlacesAux;
        }
    }
}
