namespace prims_kruskal
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDibujarNodo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKruskal = new System.Windows.Forms.Button();
            this.btnPrim = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numHeu = new System.Windows.Forms.NumericUpDown();
            this.btnEliminarNodo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkFlecha = new System.Windows.Forms.CheckBox();
            this.btnEliminarEnlace = new System.Windows.Forms.Button();
            this.numPeso = new System.Windows.Forms.NumericUpDown();
            this.Hasta = new System.Windows.Forms.ComboBox();
            this.Desde = new System.Windows.Forms.ComboBox();
            this.btnDibujarEnlace = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grabarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grabarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kruskalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costoUniformeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.resetearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.box = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlabelGrabado = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlabelArchivo = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeu)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDibujarNodo
            // 
            this.btnDibujarNodo.Location = new System.Drawing.Point(10, 64);
            this.btnDibujarNodo.Name = "btnDibujarNodo";
            this.btnDibujarNodo.Size = new System.Drawing.Size(112, 23);
            this.btnDibujarNodo.TabIndex = 0;
            this.btnDibujarNodo.Text = "Inserta";
            this.btnDibujarNodo.UseVisualStyleBackColor = true;
            this.btnDibujarNodo.Click += new System.EventHandler(this.btnDibujarNodo_Click);
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(10, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnKruskal);
            this.groupBox1.Controls.Add(this.btnPrim);
            this.groupBox1.Location = new System.Drawing.Point(19, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 46);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algoritmo";
            // 
            // btnKruskal
            // 
            this.btnKruskal.Location = new System.Drawing.Point(167, 17);
            this.btnKruskal.Name = "btnKruskal";
            this.btnKruskal.Size = new System.Drawing.Size(62, 23);
            this.btnKruskal.TabIndex = 1;
            this.btnKruskal.Text = "Kruskal";
            this.btnKruskal.UseVisualStyleBackColor = true;
            this.btnKruskal.Click += new System.EventHandler(this.btnKruskal_Click);
            // 
            // btnPrim
            // 
            this.btnPrim.Location = new System.Drawing.Point(20, 17);
            this.btnPrim.Name = "btnPrim";
            this.btnPrim.Size = new System.Drawing.Size(62, 23);
            this.btnPrim.TabIndex = 0;
            this.btnPrim.Text = "Prim";
            this.btnPrim.UseVisualStyleBackColor = true;
            this.btnPrim.Click += new System.EventHandler(this.btnPrim_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numHeu);
            this.groupBox2.Controls.Add(this.btnEliminarNodo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btnDibujarNodo);
            this.groupBox2.Location = new System.Drawing.Point(19, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 91);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insertar Nodo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Heuristica";
            // 
            // numHeu
            // 
            this.numHeu.Location = new System.Drawing.Point(146, 39);
            this.numHeu.Name = "numHeu";
            this.numHeu.Size = new System.Drawing.Size(55, 20);
            this.numHeu.TabIndex = 13;
            // 
            // btnEliminarNodo
            // 
            this.btnEliminarNodo.Location = new System.Drawing.Point(182, 64);
            this.btnEliminarNodo.Name = "btnEliminarNodo";
            this.btnEliminarNodo.Size = new System.Drawing.Size(79, 23);
            this.btnEliminarNodo.TabIndex = 8;
            this.btnEliminarNodo.Text = "Elimina";
            this.btnEliminarNodo.UseVisualStyleBackColor = true;
            this.btnEliminarNodo.Click += new System.EventHandler(this.btnEliminarNodo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkFlecha);
            this.groupBox3.Controls.Add(this.btnEliminarEnlace);
            this.groupBox3.Controls.Add(this.numPeso);
            this.groupBox3.Controls.Add(this.Hasta);
            this.groupBox3.Controls.Add(this.Desde);
            this.groupBox3.Controls.Add(this.btnDibujarEnlace);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(19, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 119);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insertar Enlace";
            // 
            // chkFlecha
            // 
            this.chkFlecha.AutoSize = true;
            this.chkFlecha.Location = new System.Drawing.Point(148, 64);
            this.chkFlecha.Name = "chkFlecha";
            this.chkFlecha.Size = new System.Drawing.Size(113, 17);
            this.chkFlecha.TabIndex = 15;
            this.chkFlecha.Text = "Muestra Flecha";
            this.chkFlecha.UseVisualStyleBackColor = true;
            this.chkFlecha.CheckedChanged += new System.EventHandler(this.chkFlecha_CheckedChanged);
            // 
            // btnEliminarEnlace
            // 
            this.btnEliminarEnlace.Location = new System.Drawing.Point(192, 87);
            this.btnEliminarEnlace.Name = "btnEliminarEnlace";
            this.btnEliminarEnlace.Size = new System.Drawing.Size(69, 23);
            this.btnEliminarEnlace.TabIndex = 14;
            this.btnEliminarEnlace.Text = "Elimina";
            this.btnEliminarEnlace.UseVisualStyleBackColor = true;
            this.btnEliminarEnlace.Click += new System.EventHandler(this.btnEliminarEnlace_Click);
            // 
            // numPeso
            // 
            this.numPeso.Location = new System.Drawing.Point(34, 38);
            this.numPeso.Name = "numPeso";
            this.numPeso.Size = new System.Drawing.Size(72, 20);
            this.numPeso.TabIndex = 12;
            // 
            // Hasta
            // 
            this.Hasta.FormattingEnabled = true;
            this.Hasta.Location = new System.Drawing.Point(180, 37);
            this.Hasta.Name = "Hasta";
            this.Hasta.Size = new System.Drawing.Size(52, 21);
            this.Hasta.TabIndex = 11;
            // 
            // Desde
            // 
            this.Desde.FormattingEnabled = true;
            this.Desde.Location = new System.Drawing.Point(120, 37);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(52, 21);
            this.Desde.TabIndex = 10;
            // 
            // btnDibujarEnlace
            // 
            this.btnDibujarEnlace.Location = new System.Drawing.Point(10, 90);
            this.btnDibujarEnlace.Name = "btnDibujarEnlace";
            this.btnDibujarEnlace.Size = new System.Drawing.Size(141, 23);
            this.btnDibujarEnlace.TabIndex = 13;
            this.btnDibujarEnlace.Text = "Inserta / Modifica";
            this.btnDibujarEnlace.UseVisualStyleBackColor = true;
            this.btnDibujarEnlace.Click += new System.EventHandler(this.btnDibujarEnlace_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Desde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hasta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Peso";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(7, 25);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Controls.Add(this.lblResultado);
            this.groupBox4.Location = new System.Drawing.Point(19, 303);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(267, 234);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultado";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.algoritmoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(851, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.grabarToolStripMenuItem1,
            this.grabarToolStripMenuItem,
            this.toolStripMenuItem3,
            this.salirToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "&Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "&Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // grabarToolStripMenuItem1
            // 
            this.grabarToolStripMenuItem1.Name = "grabarToolStripMenuItem1";
            this.grabarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.grabarToolStripMenuItem1.Text = "&Grabar";
            this.grabarToolStripMenuItem1.Click += new System.EventHandler(this.grabarToolStripMenuItem1_Click);
            // 
            // grabarToolStripMenuItem
            // 
            this.grabarToolStripMenuItem.Name = "grabarToolStripMenuItem";
            this.grabarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grabarToolStripMenuItem.Text = "Grabar &como ...";
            this.grabarToolStripMenuItem.Click += new System.EventHandler(this.grabarComoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // algoritmoToolStripMenuItem
            // 
            this.algoritmoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kruskalToolStripMenuItem,
            this.costoUniformeToolStripMenuItem,
            this.aToolStripMenuItem,
            this.toolStripMenuItem2,
            this.resetearToolStripMenuItem});
            this.algoritmoToolStripMenuItem.Name = "algoritmoToolStripMenuItem";
            this.algoritmoToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.algoritmoToolStripMenuItem.Text = "Algoritmo";
            // 
            // kruskalToolStripMenuItem
            // 
            this.kruskalToolStripMenuItem.Name = "kruskalToolStripMenuItem";
            this.kruskalToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kruskalToolStripMenuItem.Text = "&Kruskal";
            this.kruskalToolStripMenuItem.Click += new System.EventHandler(this.btnKruskal_Click);
            // 
            // costoUniformeToolStripMenuItem
            // 
            this.costoUniformeToolStripMenuItem.Name = "costoUniformeToolStripMenuItem";
            this.costoUniformeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.costoUniformeToolStripMenuItem.Text = "&Costo Uniforme";
            this.costoUniformeToolStripMenuItem.Click += new System.EventHandler(this.costoUniformeToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aToolStripMenuItem.Text = "A*";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(155, 6);
            // 
            // resetearToolStripMenuItem
            // 
            this.resetearToolStripMenuItem.Name = "resetearToolStripMenuItem";
            this.resetearToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.resetearToolStripMenuItem.Text = "&Resetear";
            this.resetearToolStripMenuItem.Click += new System.EventHandler(this.resetearToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Text|*.txt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Texto|*.txt";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox5.Location = new System.Drawing.Point(547, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(304, 537);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            // 
            // box
            // 
            this.box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box.Location = new System.Drawing.Point(0, 0);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(547, 537);
            this.box.TabIndex = 22;
            this.box.TabStop = false;
            this.box.Paint += new System.Windows.Forms.PaintEventHandler(this.box_Paint);
            this.box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.box.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.box.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlabelGrabado,
            this.tlabelArchivo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 561);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(851, 24);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlabelGrabado
            // 
            this.tlabelGrabado.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tlabelGrabado.Name = "tlabelGrabado";
            this.tlabelGrabado.Size = new System.Drawing.Size(16, 19);
            this.tlabelGrabado.Text = "*";
            // 
            // tlabelArchivo
            // 
            this.tlabelArchivo.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tlabelArchivo.Name = "tlabelArchivo";
            this.tlabelArchivo.Size = new System.Drawing.Size(14, 19);
            this.tlabelArchivo.Text = " ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 537);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.box);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 537);
            this.panel2.TabIndex = 23;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Implementacion Prim / Kruskal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDibujarNodo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Hasta;
        private System.Windows.Forms.ComboBox Desde;
        private System.Windows.Forms.Button btnDibujarEnlace;
        private System.Windows.Forms.Button btnPrim;
        private System.Windows.Forms.Button btnKruskal;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem grabarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown numPeso;
        private System.Windows.Forms.Button btnEliminarEnlace;
        private System.Windows.Forms.Button btnEliminarNodo;
        private System.Windows.Forms.PictureBox box;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tlabelGrabado;
        private System.Windows.Forms.ToolStripStatusLabel tlabelArchivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem grabarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkFlecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numHeu;
        private System.Windows.Forms.ToolStripMenuItem algoritmoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kruskalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem costoUniformeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem resetearToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
    }
}

