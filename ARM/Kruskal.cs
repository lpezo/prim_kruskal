using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM
{
    public class Kruskal
    {
        public static List<Enlace> Ejecutar(Grafo g)
        {
            var arm = new List<Enlace>();                       // Creo la lista de enlaces que contendra el ARM 
            var enlaces = g.GetEnlacesDeMenorAMayor();          // Obtengo la lista de enlaces del nodo ordenada de menor a mayor peso
            foreach (var enlace in enlaces)                     // Recorro la lista de enlaces
            {
                if (!enlace.NodosVisitados())                   // Si el enlaces no tiene ambos nodos visitados
                {
                    enlace.NodoA.visitado = true;               // Marco el NodoA del enlace como visitado
                    enlace.NodoB.visitado = true;               // Marco el NodoB del enlace como visitado
                    arm.Add(enlace);                            // Agrego el enlace al ARM
                }
                else
                {
                    if(!FormaCiclo(g,g.GetEnlacesVisitados(enlace.NodoA), new List<Enlace>(), arm, enlace.NodoA, enlace.NodoB))  // Si no se forma un ciclo
                    {
                        arm.Add(enlace);                       // Agrego el enlace al ARM
                    }
                }
            }
            return arm;                                        // Devuelve el ARM
        }

        public static List<Enlace> Ejecutar2(Grafo g)
        {
            var arm = new List<Enlace>();
            var enlaces = g.GetEnlacesDeMenorAMayor();
            foreach (var enlace in enlaces)
            {
                if (!enlace.NodosVisitados())                   // Si el enlaces no tiene ambos nodos visitados
                {
                    enlace.NodoA.visitado = true;               // Marco el NodoA del enlace como visitado
                    enlace.NodoB.visitado = true;               // Marco el NodoB del enlace como visitado
                    arm.Add(enlace);                            // Agrego el enlace al ARM
                    if (arm.Count == g.Nodos.Count - 1)
                        break;
                }
            }
            return arm;
        }
        
        /// <summary>
        /// Verifica que no se forme un ciclo entre el NodoA y el NodoB
        /// </summary>
        /// <param name="g">Grafo</param>
        /// <param name="enlaces">Lista de enlaces que contienen el NodoA</param>
        /// <param name="visitados">Lista de enlaces visitado</param>
        /// <param name="resultado">ARM parcial del algoritmo de Kruskal</param>
        /// <param name="nodoA">NodoA</param>
        /// <param name="nodoB">NodoB</param>
        /// <returns>Retorna true si exciste ciclo</returns>
        public static bool FormaCiclo(Grafo g, List<Enlace> enlaces, List<Enlace> visitados, List<Enlace> resultado, Nodo nodoA, Nodo nodoB)
        {
            foreach (var e in enlaces)
	        {
		       var otroNodo = e.GetOtroNodo(nodoA);
                
                if(otroNodo == nodoB && resultado.Contains(e))
                    return true;

                visitados.Add(e);
                var enlacesOtroNodo = g.GetEnlacesVisitados(otroNodo);
                BorrarEnlacesVisitados(enlacesOtroNodo, visitados);
                
                if (FormaCiclo(g, enlacesOtroNodo, visitados, resultado, otroNodo, nodoB))
                    return true;
	        } 
            
            return false;
        }

        /// <summary>
        /// Elimina los enlaces visitados 
        /// </summary>
        /// <param name="enlaces">Lista de enlaces</param>
        /// <param name="visitados">Lista de enlaces a eliminar</param>
        private static void BorrarEnlacesVisitados(List<Enlace> enlaces, List<Enlace> visitados)
        {
            foreach (var e in visitados)
            {
                enlaces.Remove(e); 
            }
        }
        
    }
}
