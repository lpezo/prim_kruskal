using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM
{
    public class Nodo
    {
        public string nombre { get; set; }
        public bool visitado { get; set; }
        public int heuristica { get; set; }

        /// <summary>
        ///  Constructor de Nodo inicializa la clase
        /// </summary>
        /// <param name="nombre"></param>
        public Nodo(string nombre) // Inicializo la clase Nodo
        {
            this.nombre = nombre;
            this.visitado = false;
        }

        /// <summary>
        ///  Constructor de Nodo inicializa la clase
        /// </summary>
        public Nodo()  
        {
            this.nombre = null;
        }
    }
}
