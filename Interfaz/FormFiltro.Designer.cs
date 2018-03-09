namespace Interfaz
{
    partial class FormFiltro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tablaCiudades = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLatitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLongitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPoblacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPoblacion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gifCargando = new System.Windows.Forms.PictureBox();
            this.mapa = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbInsercion = new System.Windows.Forms.RadioButton();
            this.rbFuerzaBruta = new System.Windows.Forms.RadioButton();
            this.rbKruskal = new System.Windows.Forms.RadioButton();
            this.labCiudadInicial = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.workFiltrar = new System.ComponentModel.BackgroundWorker();
            this.workKruskal = new System.ComponentModel.BackgroundWorker();
            this.workFuerzaBruta = new System.ComponentModel.BackgroundWorker();
            this.workInsercion = new System.ComponentModel.BackgroundWorker();
            this.listaCiudades = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCiudades)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gifCargando)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.tablaCiudades);
            this.groupBox1.Controls.Add(this.labCiudadInicial);
            this.groupBox1.Controls.Add(this.butFiltrar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPoblacion);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar ciudades por población";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 208);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(477, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // tablaCiudades
            // 
            this.tablaCiudades.AllowUserToAddRows = false;
            this.tablaCiudades.AllowUserToDeleteRows = false;
            this.tablaCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCiudades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colLatitud,
            this.colLongitud,
            this.colPoblacion});
            this.tablaCiudades.Location = new System.Drawing.Point(10, 64);
            this.tablaCiudades.Name = "tablaCiudades";
            this.tablaCiudades.ReadOnly = true;
            this.tablaCiudades.RowHeadersVisible = false;
            this.tablaCiudades.Size = new System.Drawing.Size(526, 133);
            this.tablaCiudades.TabIndex = 3;
            this.tablaCiudades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCiudades_CellContentClick);
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 200;
            // 
            // colLatitud
            // 
            this.colLatitud.HeaderText = "Latitud";
            this.colLatitud.Name = "colLatitud";
            this.colLatitud.ReadOnly = true;
            // 
            // colLongitud
            // 
            this.colLongitud.HeaderText = "Longitud";
            this.colLongitud.Name = "colLongitud";
            this.colLongitud.ReadOnly = true;
            // 
            // colPoblacion
            // 
            this.colPoblacion.HeaderText = "Población";
            this.colPoblacion.Name = "colPoblacion";
            this.colPoblacion.ReadOnly = true;
            // 
            // butFiltrar
            // 
            this.butFiltrar.Location = new System.Drawing.Point(187, 37);
            this.butFiltrar.Name = "butFiltrar";
            this.butFiltrar.Size = new System.Drawing.Size(75, 23);
            this.butFiltrar.TabIndex = 2;
            this.butFiltrar.Text = "Filtrar";
            this.butFiltrar.UseVisualStyleBackColor = true;
            this.butFiltrar.Click += new System.EventHandler(this.butFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inidique una población para realizar el filtro:";
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.Location = new System.Drawing.Point(10, 37);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(170, 20);
            this.txtPoblacion.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gifCargando);
            this.panel1.Controls.Add(this.mapa);
            this.panel1.Location = new System.Drawing.Point(13, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 254);
            this.panel1.TabIndex = 1;
            // 
            // gifCargando
            // 
            this.gifCargando.Location = new System.Drawing.Point(231, 16);
            this.gifCargando.Name = "gifCargando";
            this.gifCargando.Size = new System.Drawing.Size(220, 220);
            this.gifCargando.TabIndex = 8;
            this.gifCargando.TabStop = false;
            this.gifCargando.Visible = false;
            // 
            // mapa
            // 
            this.mapa.Bearing = 0F;
            this.mapa.CanDragMap = true;
            this.mapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapa.GrayScaleMode = false;
            this.mapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapa.LevelsKeepInMemmory = 5;
            this.mapa.Location = new System.Drawing.Point(9, 3);
            this.mapa.MarkersEnabled = true;
            this.mapa.MaxZoom = 2;
            this.mapa.MinZoom = 2;
            this.mapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapa.Name = "mapa";
            this.mapa.NegativeMode = false;
            this.mapa.PolygonsEnabled = true;
            this.mapa.RetryLoadTile = 0;
            this.mapa.RoutesEnabled = true;
            this.mapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapa.ShowTileGridLines = false;
            this.mapa.Size = new System.Drawing.Size(665, 273);
            this.mapa.TabIndex = 0;
            this.mapa.Zoom = 0D;
            this.mapa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapa_MouseDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.listaCiudades);
            this.groupBox2.Controls.Add(this.rbInsercion);
            this.groupBox2.Controls.Add(this.rbFuerzaBruta);
            this.groupBox2.Controls.Add(this.rbKruskal);
            this.groupBox2.Location = new System.Drawing.Point(563, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 237);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Métodos solución:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rbInsercion
            // 
            this.rbInsercion.AutoSize = true;
            this.rbInsercion.Location = new System.Drawing.Point(6, 66);
            this.rbInsercion.Name = "rbInsercion";
            this.rbInsercion.Size = new System.Drawing.Size(68, 17);
            this.rbInsercion.TabIndex = 7;
            this.rbInsercion.TabStop = true;
            this.rbInsercion.Text = "Inserción";
            this.rbInsercion.UseVisualStyleBackColor = true;
            this.rbInsercion.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbFuerzaBruta
            // 
            this.rbFuerzaBruta.AutoSize = true;
            this.rbFuerzaBruta.Location = new System.Drawing.Point(6, 43);
            this.rbFuerzaBruta.Name = "rbFuerzaBruta";
            this.rbFuerzaBruta.Size = new System.Drawing.Size(85, 17);
            this.rbFuerzaBruta.TabIndex = 6;
            this.rbFuerzaBruta.TabStop = true;
            this.rbFuerzaBruta.Text = "Fuerza Bruta";
            this.rbFuerzaBruta.UseVisualStyleBackColor = true;
            this.rbFuerzaBruta.CheckedChanged += new System.EventHandler(this.rbFuerzaBruta_CheckedChanged);
            // 
            // rbKruskal
            // 
            this.rbKruskal.AutoSize = true;
            this.rbKruskal.Checked = true;
            this.rbKruskal.Location = new System.Drawing.Point(6, 21);
            this.rbKruskal.Name = "rbKruskal";
            this.rbKruskal.Size = new System.Drawing.Size(108, 17);
            this.rbKruskal.TabIndex = 5;
            this.rbKruskal.TabStop = true;
            this.rbKruskal.Text = "Kruskal PreOrden";
            this.rbKruskal.UseVisualStyleBackColor = true;
            this.rbKruskal.CheckedChanged += new System.EventHandler(this.rbKruskal_CheckedChanged);
            // 
            // labCiudadInicial
            // 
            this.labCiudadInicial.AutoSize = true;
            this.labCiudadInicial.Location = new System.Drawing.Point(386, 43);
            this.labCiudadInicial.Name = "labCiudadInicial";
            this.labCiudadInicial.Size = new System.Drawing.Size(16, 13);
            this.labCiudadInicial.TabIndex = 4;
            this.labCiudadInicial.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ciudad inicial:";
            // 
            // workFiltrar
            // 
            this.workFiltrar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workFiltrar_DoWork);
            this.workFiltrar.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workFiltrar_ProgressChanged);
            this.workFiltrar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workFiltrar_RunWorkerCompleted);
            // 
            // workKruskal
            // 
            this.workKruskal.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workKruskal_DoWork);
            this.workKruskal.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workKruskal_RunWorkerCompleted);
            // 
            // workFuerzaBruta
            // 
            this.workFuerzaBruta.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workFuerzaBruta_DoWork);
            this.workFuerzaBruta.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workFuerzaBruta_RunWorkerCompleted);
            // 
            // workInsercion
            // 
            this.workInsercion.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workInsercion_DoWork);
            this.workInsercion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workInsercion_RunWorkerCompleted);
            // 
            // listaCiudades
            // 
            this.listaCiudades.FormattingEnabled = true;
            this.listaCiudades.Location = new System.Drawing.Point(6, 108);
            this.listaCiudades.Name = "listaCiudades";
            this.listaCiudades.Size = new System.Drawing.Size(120, 121);
            this.listaCiudades.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lista de ciudades:";
            // 
            // FormFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 512);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormFiltro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro de ciudades";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFiltro_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCiudades)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gifCargando)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tablaCiudades;
        private System.Windows.Forms.Button butFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPoblacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLatitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLongitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPoblacion;
        private System.Windows.Forms.Panel panel1;
        private GMap.NET.WindowsForms.GMapControl mapa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labCiudadInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbFuerzaBruta;
        private System.Windows.Forms.RadioButton rbKruskal;
        private System.Windows.Forms.RadioButton rbInsercion;
        private System.ComponentModel.BackgroundWorker workFiltrar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox gifCargando;
        private System.ComponentModel.BackgroundWorker workKruskal;
        private System.ComponentModel.BackgroundWorker workFuerzaBruta;
        private System.ComponentModel.BackgroundWorker workInsercion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listaCiudades;
    }
}