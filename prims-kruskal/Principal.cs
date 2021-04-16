using ARM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prims_kruskal
{
    public partial class Principal : Form
    {
        //public static Form K;
        private NodoVisual seleccionado;
        private List<Nodo> nodos;
        private List<Enlace> enlaces;
        private Grafo g = new Grafo();
        private List<Enlace> resolucion;
        private int indiceResolucion;
        private NodoVisual NodoInserta = null;
        private const int TamNodo = 20;
        private bool salvado = true;
        private string rutaArchivo = null;
        private bool muestraFlecha = false;

        SolidBrush pincelNegro = new SolidBrush(Color.Black);
        SolidBrush pincelVerde = new SolidBrush(Color.Green);

        Font letra = new Font("Arial", 11);

        const string tagNodos = "[nodos]";
        const string tagEnlaces = "[enlaces]";

        public Principal() // constructor
        {
            InitializeComponent();
            this.nodos = new List<Nodo>(); // lista de nodos
            this.enlaces = new List<Enlace>();
            this.resolucion = new List<Enlace>();
            this.indiceResolucion = 0;
            //K = this;
            this.seleccionado = null; //inicializa seleccionado en null 
            ///////////////////
        }
        private void btnDibujarNodo_Click(object sender, EventArgs e) // Funcion: recibe los valores para dibijar el nodo, crea un nuevo punto y un nuevo nodo y llama a la funcion para dibujar
        {
            NodoVisual n = new NodoVisual();

            if (string.IsNullOrWhiteSpace(this.textBox1.Text))
            {
                MessageBox.Show("El nombre no puede ser blanco", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            n.nombre = this.textBox1.Text.Trim();
            n.heuristica = (int)this.numHeu.Value;

            foreach (var nodo in nodos)
            {
                if (n.nombre == nodo.nombre)
                {
                    MessageBox.Show("No se puede repetir el nombre de un Nodo", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            NodoInserta = n;
        }
        private void btnEliminarNodo_Click(object sender, EventArgs e)
        {
            var unodo = this.nodos.FirstOrDefault(p => p.nombre == this.textBox1.Text.Trim());
            if (unodo != null)
            {
                //Elimina enlaces
                var uenlace = this.enlaces.FirstOrDefault(p => p.NodoA == unodo || p.NodoB == unodo);
                while (uenlace != null)
                {
                    this.g.BorrarEnlace(uenlace);
                    this.enlaces.Remove(uenlace);

                    uenlace = this.enlaces.FirstOrDefault(p => p.NodoA == unodo || p.NodoB == unodo);
                }

                this.nodos.Remove(unodo);
                this.g.Nodos.Remove(unodo);
                Desde.Items.Remove(unodo.nombre);
                Hasta.Items.Remove(unodo.nombre);

                Dibujar(true);
            }

        }


        private void btnDibujarEnlace_Click(object sender, EventArgs e) //Evento: Dibujo; Captura los elementos seleccionados en el dropdown y luego los busca por el nombre en la lista de nodos, luego se los manda a la funcion de dibujar la linea
        {
            try
            {
                var desde = this.Desde.Items[this.Desde.SelectedIndex]; //elem seleccionado desde
                var hasta = this.Hasta.Items[this.Hasta.SelectedIndex]; //elem seleccionado hasta
                var nodo_desde = this.nodos.FirstOrDefault(d => d.nombre == desde); //busca en la lista de nodos donde el nombre sea el mismo
                var nodo_hasta = this.nodos.FirstOrDefault(h => h.nombre == hasta); //busca en la lista de nodos donde el nombre sea el mismo
                var peso = Convert.ToInt32(this.numPeso.Value);
                this.DibujarEnlace(peso, (NodoVisual)nodo_desde, (NodoVisual)nodo_hasta);
                //this.Desde.ResetText();
                //this.Hasta.ResetText();
                //this.numericUpDown1.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void btnEliminarEnlace_Click(object sender, EventArgs e)
        {
            var desde = this.Desde.Items[this.Desde.SelectedIndex]; //elem seleccionado desde
            var hasta = this.Hasta.Items[this.Hasta.SelectedIndex]; //elem seleccionado hasta
            var nodo_desde = this.nodos.FirstOrDefault(d => d.nombre == desde); //busca en la lista de nodos donde el nombre sea el mismo
            var nodo_hasta = this.nodos.FirstOrDefault(h => h.nombre == hasta); //busca en la lista de nodos donde el nombre sea el mismo

            if (nodo_desde == null || nodo_hasta == null) { 
                MessageBox.Show("No se pudo ubicar el enlace", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.enlaces.Count > 0)
            {
                var obj = this.enlaces.FirstOrDefault(Enlace => nodo_desde == Enlace.NodoA && nodo_hasta == Enlace.NodoB || nodo_hasta == Enlace.NodoA && nodo_desde == Enlace.NodoB);
                if (obj != null)
                {
                    this.g.BorrarEnlace(obj);
                    this.enlaces.Remove(obj);
                }
                Dibujar(true);
            }

        }
        private void Dibujar(bool cambio) // Funcion: Dibujo; Dibuja los nodos con sus respectivos nombres, a su ves carga los nombres los dropdowns.
        {
            if (cambio)
            {
                salvado = false;
                tlabelGrabado.Text = salvado ? "Salvado" : "Sin Grabar";
            }
            box.Invalidate();
        }

        private void box_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(pincelNegro, 3);
            //Desde.Items.Clear();
            //Hasta.Items.Clear();
            Graphics s = e.Graphics;
            //s.Clear(SystemColors.ActiveCaption);
            foreach (NodoVisual nodo in this.nodos)
            {
                //Desde.Items.Add(nodo.nombre);
                //Hasta.Items.Add(nodo.nombre);
                Point posLetra = nodo.PosicionLetra(TamNodo);
                s.FillEllipse(pincelNegro, nodo.Center.X, nodo.Center.Y, TamNodo, TamNodo);
                //s.DrawString(nodo.nombre, letra, pincelNegro, nodo.Center.X + 7, nodo.Center.Y + TamNodo);
                s.DrawString(nodo.nombre, letra, pincelNegro, posLetra);
                if (nodo.heuristica > 0)
                    s.DrawString(nodo.heuristica.ToString(), letra, pincelNegro, nodo.Center.X + 7, nodo.Center.Y - TamNodo);
            }
            foreach (EnlaceVisual enlace in this.enlaces)
            {
                Point nodoA = new Point(((NodoVisual)enlace.NodoA).Center.X + TamNodo/2, ((NodoVisual)enlace.NodoA).Center.Y + TamNodo/2);
                Point nodoB = new Point(((NodoVisual)enlace.NodoB).Center.X + TamNodo/2, ((NodoVisual)enlace.NodoB).Center.Y + TamNodo/2);
                Point medio = enlace.Medio;
                Point posLetra = ((EnlaceVisual)enlace).PosicionLetra(TamNodo/2);
                
                if (muestraFlecha)
                {
                    var endcap = enlace.getEndcap(nodoA, nodoB);
                    var penarrow = new Pen(enlace.Color, 6);
                    s.DrawLine(penarrow, nodoB, endcap.Item1);
                    s.DrawLine(penarrow, nodoB, endcap.Item2);
                }
                var penlinea = new Pen(enlace.Color, 3);
                s.DrawLine(penlinea, nodoA, nodoB);
                s.FillEllipse(pincelVerde, enlace.Medio.X, medio.Y, TamNodo/2, TamNodo/2);
                //s.DrawString(enlace.Peso.ToString(), letra, pincelVerde, medio.X + 3, medio.Y + TamNodo/2);
                s.DrawString(enlace.Peso.ToString(), letra, pincelVerde, posLetra);
            }

            if (NodoInserta != null && NodoInserta.Center != null)
            {
                s.FillEllipse(Brushes.Gray, NodoInserta.Center.X, NodoInserta.Center.Y, TamNodo, TamNodo);
                s.DrawString(NodoInserta.nombre, letra, pincelNegro, NodoInserta.Center.X + 7, NodoInserta.Center.Y + TamNodo);
            }
        }

        private void DibujarEnlace(int peso, NodoVisual desde, NodoVisual hasta) // Funcion : Dibujo; Se encarga de trazar una linea entre dos nodos
        {
            Point d = new Point(desde.Center.X + TamNodo/2, desde.Center.Y + TamNodo/2);
            Point h = new Point(hasta.Center.X + TamNodo/2, hasta.Center.Y + TamNodo/2);
            EnlaceVisual e = new EnlaceVisual(peso, desde, hasta);

            bool selectEnlace = true;
            if (this.enlaces.Count > 0)
            {
                foreach (var Enlace in enlaces)
                {
                    if (e.NodoA == Enlace.NodoA && e.NodoB == Enlace.NodoB || e.NodoB == Enlace.NodoA && e.NodoA == Enlace.NodoB)
                    {
                        //MessageBox.Show("No se puede repetir un enlace ya creado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Enlace.Peso = peso;
                        this.Dibujar(true);
                        selectEnlace = false;
                        return;
                    }
                }
            }
            if (e.NodoA == e.NodoB)
            {
                MessageBox.Show("No se puede crear un enlace a si mismo", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                selectEnlace = false;
            }
            if (selectEnlace)
            {
                enlaces.Add(e);
                this.g.AgregarEnlace(e);
                this.Dibujar(true);
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) //evento: movimiento; genera un cuadrado alrededor del circulo que al tocarlo simula la seleccion del nodo
        {
            if (NodoInserta != null)
            {
                AgregaNodo(NodoInserta.Clone() as NodoVisual);
                NodoInserta = null;
                Dibujar(true);
                return;
            }

            foreach (NodoVisual n in this.nodos)
            {
                if ((n.Center.X <= e.X) && (n.Center.X + TamNodo >= e.X) && (n.Center.Y <= e.Y) && (n.Center.Y + TamNodo >= e.Y))
                {
                    if (e.Button == MouseButtons.Left)
                        this.seleccionado = n;
                    else
                    {
                        n.SiguientePosicionLetra();
                        Dibujar(true);
                    }
                    return;
                }
            }

            foreach (EnlaceVisual enl in this.enlaces)
            {
                if ((enl.CurMedio.X <= e.X) && (enl.CurMedio.X + TamNodo / 2 >= e.X) && (enl.CurMedio.Y <= e.Y) && (enl.CurMedio.Y + TamNodo / 2 >= e.Y))
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        enl.SiguientePosicionLetra();
                        Dibujar(true);
                    }
                    else if (e.Button == MouseButtons.Left)
                    {
                        this.Desde.Text = enl.NodoA.nombre;
                        this.Hasta.Text = enl.NodoB.nombre;
                        this.numPeso.Value = enl.Peso;
                    }
                    return;
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e) //evento: movimiento; controla el movimiento del nodo, va actualizando el x e y del nodo y redibujandolo a medida que se mueve
        {
            if (this.seleccionado != null) 
            {
                this.seleccionado.Center.X = e.X- TamNodo/2;
                this.seleccionado.Center.Y = e.Y- TamNodo/2;
                //Graphics s = prims_kruskal.Principal.K.CreateGraphics();
                //s.Clear(this.BackColor);
                this.Dibujar(true);
            }
            if (NodoInserta != null)
            {
                if (NodoInserta.Center == null)
                    NodoInserta.Center = new Point(e.X- TamNodo/2, e.Y- TamNodo/2);
                else
                {
                    NodoInserta.Center.X = e.X- TamNodo/2;
                    NodoInserta.Center.Y = e.Y- TamNodo/2;
                }
                this.Dibujar(true);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)// evento: movimiento; suelta el nodo cuando soltas el click del mouse
        {
            this.seleccionado = null;
        }

        private void btnPrim_Click(object sender, EventArgs e)
        {
            this.ResetResolucion();
            this.resolucion = Prim.Ejecutar(g);
            this.MarcarResultado();
            this.Dibujar(false);
            this.ImprimirResultado();
        }

        private void btnKruskal_Click(object sender, EventArgs e)
        {
            this.ResetResolucion();
            this.resolucion = Kruskal.Ejecutar(g);
            this.ImprimirResultado();
            this.MarcarResultado();
            this.Dibujar(false);
        }
        private void resetearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ResetResolucion();
            this.ImprimirResultado();
            this.Dibujar(false);
        }
        private void ImprimirResultado()
        {
            string resultado = "Lista de Enlaces: " + Environment.NewLine;
            int pesoTotal = 0;
            foreach (var enlace in this.resolucion)
            {
                resultado += "[" + enlace.NodoA.nombre + "-" + enlace.NodoB.nombre + "]" + Environment.NewLine;
                pesoTotal += enlace.Peso;
            }
            this.lblResultado.Text = resultado + "Costo Total: "+ pesoTotal; 
        }
        private void MarcarResultado()
        {
            for (int indiceResolucion = 0; indiceResolucion < this.resolucion.Count; indiceResolucion++)
            {
                ((EnlaceVisual)this.resolucion[indiceResolucion]).Color = Color.Red;
            }
            indiceResolucion = -1;
            this.Dibujar(false);
        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (indiceResolucion <= 0)
            {
                for (int indiceResolucion = 0; indiceResolucion < this.resolucion.Count; indiceResolucion++)
                {
                    ((EnlaceVisual)this.resolucion[indiceResolucion]).Color = Color.Gray;
                }
            }
            if (indiceResolucion >= 0 && indiceResolucion < this.resolucion.Count)
                ((EnlaceVisual)this.resolucion[indiceResolucion]).Color = Color.Red;
            indiceResolucion++;
            if (indiceResolucion >= this.resolucion.Count)
                indiceResolucion = -1;
            Dibujar(false);
        }
        private void ResetResolucion() {
            this.resolucion = new List<Enlace>();
            this.indiceResolucion = 0;
            this.lblResultado.Text = string.Empty;

            foreach (EnlaceVisual enlace in this.enlaces)
            {
                enlace.Color = Color.Gray;
            }

            foreach (NodoVisual nodo in this.nodos)
            {
                nodo.visitado = false;
            }

        }

        private void Reset()
        {
            this.g = new Grafo();
            this.nodos = new List<Nodo>();
            this.enlaces = new List<Enlace>();
            this.resolucion = new List<Enlace>();
            this.indiceResolucion = 0;
            this.lblResultado.Text = string.Empty;
            this.Desde.Items.Clear();
            this.Hasta.Items.Clear();
            this.Dibujar(false);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void grabarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (rutaArchivo == null)
            {
                grabarComoToolStripMenuItem_Click(sender, e);
                return;
            }
            Grabar();
        }
        private void grabarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rutaArchivo != null)
                saveFileDialog1.FileName = rutaArchivo;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = saveFileDialog1.FileName;
                Grabar();
            }
        }
        private void Grabar()
        {
            using (var sw = new StreamWriter(rutaArchivo, false, Encoding.Default))
            {
                sw.WriteLine(tagNodos);
                foreach (var node in this.nodos)
                {
                    var nodov = node as NodoVisual;
                    //sw.WriteLine("{0},{1},{2},{3}", nodov.nombre, nodov.Center.X, nodov.Center.Y, nodov.heuristica);
                    sw.WriteLine(nodov);
                }
                sw.WriteLine(tagEnlaces);
                foreach (var enlace in this.enlaces)
                {
                    var enl = enlace as EnlaceVisual;
                    sw.WriteLine(enlace);
                }
            }
            salvado = true;
            tlabelGrabado.Text = " ";

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.Reset();
                    if (File.Exists(openFileDialog1.FileName))
                    {
                        rutaArchivo = openFileDialog1.FileName;
                        var tam = new Point();
                        using (var read = new StreamReader(openFileDialog1.FileName, Encoding.Default))
                        {
                            bool esnodo = true;
                            string linea;
                            while ( (linea = read.ReadLine()) != null)
                            {
                                if (linea.StartsWith("[")) {
                                    esnodo = (linea.Equals(tagNodos));
                                    continue;
                                }
                                if (esnodo)
                                {
                                    var n1 = new NodoVisual(linea);
                                    AgregaNodo(n1);
                                    if (n1.Center.X > tam.X || n1.Center.Y > tam.Y)
                                        tam = n1.Center;
                                }
                                else
                                {
                                    var e1 = new EnlaceVisual(linea, this.nodos);
                                    g.AgregarEnlace(e1);
                                    this.enlaces.Add(e1);
                                }
                            }
                        }
                        tam.Offset(20, 20);
                        salvado = true;
                        tlabelArchivo.Text = rutaArchivo;
                        tlabelGrabado.Text = " ";

                        string rutaimagen = Path.ChangeExtension(openFileDialog1.FileName, "png");
                        this.box.Location = new Point(0, 0);
                        if (File.Exists(rutaimagen))
                        {
                            this.box.Dock = DockStyle.None;
                            this.box.Image = Image.FromFile(rutaimagen);
                            var nsize = this.box.Image.Size;
                            if (tam.X > nsize.Width)
                                nsize.Width = tam.X + 20;
                            if (tam.Y > nsize.Height)
                                nsize.Height = tam.Y + 20;
                            this.box.Size = nsize;
                        }
                        else
                        {
                            this.box.Image = null;
                            this.box.Dock = DockStyle.Fill;
                        }

                        this.Dibujar(false);
                    }
                    else
                        throw new Exception("No existe el archivo " + openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var eclosed = e as FormClosingEventArgs;
                if (eclosed != null)
                    eclosed.Cancel = true;
            }
        }

        private void AgregaNodo(NodoVisual n)
        {
            g.AgregarNodo(n);
            this.nodos.Add(n);
            Desde.Items.Add(n.nombre);
            Hasta.Items.Add(n.nombre);
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!salvado)
            {
                var opt = MessageBox.Show("¿Desea Salvar el Gráfico?", "Cambios hechos", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (opt == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
                if (opt == DialogResult.Yes)
                {
                    grabarToolStripMenuItem1_Click(sender, e);
                }
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!salvado)
            {
                var opt = MessageBox.Show("¿Desea Salvar el Gráfico?", "Cambios hechos", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (opt == DialogResult.Cancel)
                {
                    return;
                }
                if (opt == DialogResult.Yes)
                {
                    grabarToolStripMenuItem1_Click(sender, e);
                }
            }
            salvado = false;
            this.Reset();
            tlabelGrabado.Text = " ";
            tlabelArchivo.Text = " ";
            Dibujar(false);
        }

        private void chkFlecha_CheckedChanged(object sender, EventArgs e)
        {
            muestraFlecha = chkFlecha.Checked;
            Dibujar(false);
        }

        private void costoUniformeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Desde.Text))
            {
                MessageBox.Show("Desde vacío", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(Hasta.Text))
            {
                MessageBox.Show("Hasta vacío", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ResetResolucion();

            StringBuilder sb = new StringBuilder(1024);
            List<Nodo> lista;
            try
            {
                var resp = g.getCosto(Desde.Text, Hasta.Text, out lista);

                foreach (var nodo in lista)
                {
                    sb.AppendLine(nodo.nombre);
                }
                if (resp.enc)
                    sb.AppendLine("Costo Total " + resp.costo);
                else
                    sb.AppendLine("No encontrado!");

                this.lblResultado.Text = sb.ToString();

                this.resolucion = g.GetEnlaces(lista);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MarcarResultado();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Desde.Text))
            {
                MessageBox.Show("Desde vacío", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(Hasta.Text))
            {
                MessageBox.Show("Hasta vacío", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ResetResolucion();

            StringBuilder sb = new StringBuilder(1024);
            List<Nodo> lista;
            var resp = g.getAEstrella(Desde.Text, Hasta.Text, out lista);


            foreach (var nodo in lista)
            {
                sb.AppendLine(nodo.nombre);
            }
            if (resp.enc)
                sb.AppendLine("Costo Total " + resp.costo);
            else
                sb.AppendLine("No encontrado!");

            this.lblResultado.Text = sb.ToString();

            this.resolucion = g.GetEnlaces(lista);
            MarcarResultado();
        }


    }
}
