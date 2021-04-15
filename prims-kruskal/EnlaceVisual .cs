using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ARM;

namespace prims_kruskal
{

    public class EnlaceVisual : Enlace
    {
        public Color Color { get; set; }
        /*
         * 0: abajo
         * 1: derecha
         * 2: arriba
         * 3: izquierda
         */
        private int PosLetra { get; set; }
        
        public Point CurMedio;

        public Point Medio 
        { 
            get
                {
                    CurMedio = this.GetMedioEnlace();
                    return CurMedio;
                } 
        }

        public EnlaceVisual(int peso, Nodo nodoA, Nodo nodoB)
		{
            this.NodoA = nodoA;
            this.NodoB = nodoB;
            this.Peso = peso;
            this.Color = Color.Gray;
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}", Peso, NodoA.nombre, NodoB.nombre, PosLetra);
        }
         

        public EnlaceVisual(string linea, List<Nodo> nodos)
        {
            Nodo unodo1 = null, unodo2 = null;
            var aenl = linea.Split(',');
            for (int i = 0; i < aenl.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        this.Peso = Convert.ToInt32(aenl[i]);
                        break;
                    case 1:
                        unodo1 = nodos.Find(p => p.nombre == aenl[i]);
                        if (unodo1 == null)
                            throw new Exception(string.Format("No se encontro el nodo {0} para el enlace de peso {1}", aenl[i], this.Peso));
                        break;
                    case 2:
                        unodo2 = nodos.Find(p => p.nombre == aenl[i]);
                        if (unodo2 == null)
                            throw new Exception(string.Format("No se encontro el nodo {0} para el enlace de peso {1}", aenl[i], this.Peso));
                        break;
                    case 3:
                        this.PosLetra = Convert.ToInt32(aenl[i]);
                        break;
                }
            }
            this.NodoA = unodo1;
            this.NodoB = unodo2;
            this.Color = Color.Gray;
        }

        public void SiguientePosicionLetra()
        {
            PosLetra++;
            if (PosLetra > 3)
                PosLetra = 0;
        }
        public Point PosicionLetra(int tam)
        {
            var p = this.Peso;
            Point pos = CurMedio;
            switch (this.PosLetra)
            {
                case 0:
                    pos.Offset(0, tam);
                    while (p > 9)
                    {
                        pos.Offset(-8, 0);
                        p = p / 5;
                    }
                    break;
                case 1:
                    pos.Offset(tam, -3);
                    break;
                case 2:
                    pos.Offset(0, -tam-3);
                    while (p > 9)
                    {
                        pos.Offset(-8, 0);
                        p = p / 5;
                    }
                    break;
                case 3:
                    pos.Offset(-tam, -3);
                    while (p > 9)
                    {
                        pos.Offset(-8, 0);
                        p = p / 10;
                    }
                    break;
            }
            return pos;
        }

        private Point GetMedioEnlace()
        {
            Point pNodoA = ((NodoVisual)this.NodoA).Center; // casteo de nodo a nodovisual
            Point pNodoB = ((NodoVisual)this.NodoB).Center; // casteo de nodo a nodovisual
            int x, y = 0;
            if (pNodoA.X == pNodoB.X)
            {
                x = pNodoA.X;
            }
            else
            {
                x = (pNodoA.X + pNodoB.X) / 2;
            }
            

            if (pNodoA.Y == pNodoB.Y)
            {
                y = pNodoA.Y;
            }
            else 
            {
                y = (pNodoA.Y + pNodoB.Y) / 2;
            }
            return new Point(x, y); 
        }

        public Tuple<Point, Point> getEndcap(Point nodoA, Point nodoB)
        {
            const int separrow = 2;
            int arrowy, arrowx;

            Point endcap = new Point();
            var dify = nodoB.Y - nodoA.Y;
            var difx = nodoB.X - nodoA.X;
            //if (dify != 0)
            //arrowx = Math.Abs((10 * difx) / dify);
            arrowx = Math.Abs((int)((20 * difx) / (Math.Sqrt(difx * difx + dify * dify))));
            if (difx > 0)
                endcap.X = nodoB.X - arrowx;
            else if (difx < 0)
                endcap.X = nodoB.X + arrowx;
            else
            {
                endcap.X = nodoB.X;
                if (dify > 0)
                    endcap.Y = nodoB.Y - 20;
                else
                    endcap.Y = nodoB.Y + 20;
            }
            if (difx != 0)
            {
                arrowy = Math.Abs((arrowx * dify) / difx);
                if (dify > 0)
                    endcap.Y = nodoB.Y - arrowy;
                else if (dify < 0)
                    endcap.Y = nodoB.Y + arrowy;
                else
                    endcap.Y = nodoB.Y;
            }
            var endcap1 = endcap;
            if (difx > 0)
            {
                endcap.X = endcap.X + separrow;
                endcap1.X = endcap1.X - separrow;
            }
            else
            {
                endcap.X = endcap.X - separrow;
                endcap1.X = endcap1.X + separrow;
            }
            if (dify > 0)
            {
                endcap.Y = endcap.Y + separrow;
                endcap1.Y = endcap1.Y - separrow;
            }
            else
            {
                endcap.Y = endcap.Y - separrow;
                endcap1.Y = endcap1.Y + separrow;

            }
            return new Tuple<Point, Point>(endcap, endcap1);
        }
    }
}
