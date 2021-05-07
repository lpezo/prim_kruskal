using ARM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prims_kruskal
{
    public partial class formDatos : Form
    {
        public formDatos()
        {
            InitializeComponent();
        }

        public List<Enlace> Enlaces { get; set; }

        private void formDatos_Shown(object sender, EventArgs e)
        {
            var lista = new List<Datos>();
            foreach (var enl in Enlaces)
            {
                lista.Add(new Datos { Desde = enl.NodoA.nombre, Hasta = enl.NodoB.nombre, Peso = enl.Peso });
            }
            datosBindingSource.DataSource = lista;
        }
    }
}
