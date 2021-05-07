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
    public partial class formFondo : Form
    {
        public string Ruta { get; set; }
        private string extensiones = ".png.gif.bmp.jpg.jpge";

        public event EventHandler<EventArgImagen> OnSelecciona;

        public formFondo()
        {
            InitializeComponent();
        }

        private void formFondo_Shown(object sender, EventArgs e)
        {
            cbImagen.Items.Clear();
            cbImagen.Items.Add("<<Ninguno>>");
            //var lista = new List<string>();
            foreach (var arch in Directory.GetFiles(Ruta))
            {
                if ( extensiones.Contains( Path.GetExtension(arch).ToLower() ))
                {
                    cbImagen.Items.Add( Path.GetFileName(arch) );
                }
            }

        }

        private void cbImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pos = cbImagen.SelectedIndex;
            if (pos >= 0)
            {
                var texto = cbImagen.Items[pos] as string;
                if (OnSelecciona != null)
                {
                    var arg = new EventArgImagen { RutaImagen = texto.StartsWith("<") ? null : Path.Combine(Ruta, texto) };
                    OnSelecciona(this, arg);
                }
            }
        }

        public class EventArgImagen: EventArgs
        {
            public string RutaImagen { get; set; }
        }
    }
}
