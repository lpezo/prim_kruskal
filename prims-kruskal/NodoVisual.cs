using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ARM;

namespace prims_kruskal
{
    public class NodoVisual : Nodo, ICloneable
    {
        
        public Point Center;
        
        public ArrayList ar = new ArrayList();

        private Font font = new Font("Arial", 9);
        private SolidBrush brush = new SolidBrush(Color.Black);
        /*
         * 0: abajo
         * 1: derecha
         * 2: arriba
         * 3: izquierda
         */
        private int PosLetra { get; set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }

        public object Clone()
        {
            var nuevo = new NodoVisual();
            nuevo.nombre = this.nombre;
            nuevo.Center = this.Center;
            nuevo.heuristica = this.heuristica;
            nuevo.PosLetra = this.PosLetra;
            return nuevo;
        }

        public NodoVisual()
        {
            PosLetra = 0;
        }
        public void SiguientePosicionLetra()
        {
            PosLetra++;
            if (PosLetra > 3)
                PosLetra = 0;
        }
        public Point PosicionLetra(int tam)
        {
            var p = this.nombre.Length;
            Point pos = Center;
            switch (this.PosLetra)
            {
                case 0:
                    pos.Offset( (tam/4) + (p-1) * (-4), tam);
                    break;
                case 1:
                    pos.Offset(tam, -3);
                    break;
                case 2:
                    pos.Offset( (tam/4) + (p-1) * (-4), -tam - 2);
                    break;
                case 3:
                    pos.Offset(-tam + (p-1) * (-8), -3);
                    break;
            }
            return pos;
        }
        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4}", nombre, Center.X, Center.Y, heuristica, PosLetra);
        }
        public NodoVisual (string linea)
        {
            var anodo = linea.Split(',');
            var center = new Point();
            for (int i = 0; i < anodo.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        this.nombre = anodo[i];
                        break;
                    case 1:
                        center.X = Convert.ToInt32(anodo[i]);
                        break;
                    case 2:
                        center.Y = Convert.ToInt32(anodo[i]);
                        break;
                    case 3:
                        this.heuristica = Convert.ToInt32(anodo[i]);
                        break;
                    case 4:
                        this.PosLetra = Convert.ToInt32(anodo[i]);
                        break;
                }
            }
            this.Center = center;
        }

    }
}
