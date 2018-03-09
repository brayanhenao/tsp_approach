namespace GTAV
{
    partial class InterfazCarga
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.mapaViajeros = new GMap.NET.WindowsForms.GMapControl();
            this.panel6 = new System.Windows.Forms.Panel();
            this.butSoluciones = new System.Windows.Forms.Button();
            this.butCargarViajeros = new System.Windows.Forms.Button();
            this.txtViajeros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tablaViajeros = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colMapView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.mapaCiudades = new GMap.NET.WindowsForms.GMapControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.butCargarCiudades = new System.Windows.Forms.Button();
            this.txtCiudades = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaCiudades = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPoblacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.barraProgresoCiudades = new System.Windows.Forms.ProgressBar();
            this.barraProgresoViajeros = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaViajeros)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCiudades)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 537);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(11, 276);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(737, 250);
            this.panel3.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.mapaViajeros);
            this.panel7.Location = new System.Drawing.Point(427, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(307, 243);
            this.panel7.TabIndex = 2;
            // 
            // mapaViajeros
            // 
            this.mapaViajeros.Bearing = 0F;
            this.mapaViajeros.CanDragMap = true;
            this.mapaViajeros.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapaViajeros.GrayScaleMode = false;
            this.mapaViajeros.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapaViajeros.LevelsKeepInMemmory = 5;
            this.mapaViajeros.Location = new System.Drawing.Point(4, 4);
            this.mapaViajeros.MarkersEnabled = true;
            this.mapaViajeros.MaxZoom = 2;
            this.mapaViajeros.MinZoom = 2;
            this.mapaViajeros.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapaViajeros.Name = "mapaViajeros";
            this.mapaViajeros.NegativeMode = false;
            this.mapaViajeros.PolygonsEnabled = true;
            this.mapaViajeros.RetryLoadTile = 0;
            this.mapaViajeros.RoutesEnabled = true;
            this.mapaViajeros.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapaViajeros.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapaViajeros.ShowTileGridLines = false;
            this.mapaViajeros.Size = new System.Drawing.Size(300, 236);
            this.mapaViajeros.TabIndex = 0;
            this.mapaViajeros.Zoom = 0D;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.barraProgresoViajeros);
            this.panel6.Controls.Add(this.butSoluciones);
            this.panel6.Controls.Add(this.butCargarViajeros);
            this.panel6.Controls.Add(this.txtViajeros);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.tablaViajeros);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(417, 243);
            this.panel6.TabIndex = 5;
            // 
            // butSoluciones
            // 
            this.butSoluciones.BackColor = System.Drawing.Color.CadetBlue;
            this.butSoluciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSoluciones.ForeColor = System.Drawing.Color.White;
            this.butSoluciones.Location = new System.Drawing.Point(270, 195);
            this.butSoluciones.Name = "butSoluciones";
            this.butSoluciones.Size = new System.Drawing.Size(144, 44);
            this.butSoluciones.TabIndex = 5;
            this.butSoluciones.Text = "Solucionar todo";
            this.butSoluciones.UseVisualStyleBackColor = false;
            this.butSoluciones.Click += new System.EventHandler(this.butSoluciones_Click);
            // 
            // butCargarViajeros
            // 
            this.butCargarViajeros.BackColor = System.Drawing.SystemColors.Highlight;
            this.butCargarViajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCargarViajeros.ForeColor = System.Drawing.Color.White;
            this.butCargarViajeros.Location = new System.Drawing.Point(257, 4);
            this.butCargarViajeros.Name = "butCargarViajeros";
            this.butCargarViajeros.Size = new System.Drawing.Size(157, 39);
            this.butCargarViajeros.TabIndex = 3;
            this.butCargarViajeros.Text = "Cargar viajeros";
            this.butCargarViajeros.UseVisualStyleBackColor = false;
            this.butCargarViajeros.Click += new System.EventHandler(this.butCargarViajeros_Click);
            // 
            // txtViajeros
            // 
            this.txtViajeros.Location = new System.Drawing.Point(7, 23);
            this.txtViajeros.Name = "txtViajeros";
            this.txtViajeros.Size = new System.Drawing.Size(205, 20);
            this.txtViajeros.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Visualizar pre-carga de ciudades:";
            // 
            // tablaViajeros
            // 
            this.tablaViajeros.AllowUserToAddRows = false;
            this.tablaViajeros.AllowUserToDeleteRows = false;
            this.tablaViajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaViajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.dataGridViewTextBoxColumn1,
            this.colPreView,
            this.colMapView});
            this.tablaViajeros.EnableHeadersVisualStyles = false;
            this.tablaViajeros.Location = new System.Drawing.Point(4, 49);
            this.tablaViajeros.Name = "tablaViajeros";
            this.tablaViajeros.RowHeadersVisible = false;
            this.tablaViajeros.Size = new System.Drawing.Size(410, 140);
            this.tablaViajeros.TabIndex = 0;
            // 
            // colCodigo
            // 
            this.colCodigo.Frozen = true;
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 167;
            // 
            // colPreView
            // 
            this.colPreView.Frozen = true;
            this.colPreView.HeaderText = "PreView";
            this.colPreView.Name = "colPreView";
            this.colPreView.Width = 60;
            // 
            // colMapView
            // 
            this.colMapView.Frozen = true;
            this.colMapView.HeaderText = "MapView";
            this.colMapView.Name = "colMapView";
            this.colMapView.Width = 60;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(11, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 250);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.mapaCiudades);
            this.panel5.Location = new System.Drawing.Point(427, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(307, 243);
            this.panel5.TabIndex = 1;
            // 
            // mapaCiudades
            // 
            this.mapaCiudades.Bearing = 0F;
            this.mapaCiudades.CanDragMap = true;
            this.mapaCiudades.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapaCiudades.GrayScaleMode = false;
            this.mapaCiudades.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapaCiudades.LevelsKeepInMemmory = 5;
            this.mapaCiudades.Location = new System.Drawing.Point(4, 4);
            this.mapaCiudades.MarkersEnabled = true;
            this.mapaCiudades.MaxZoom = 2;
            this.mapaCiudades.MinZoom = 2;
            this.mapaCiudades.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapaCiudades.Name = "mapaCiudades";
            this.mapaCiudades.NegativeMode = false;
            this.mapaCiudades.PolygonsEnabled = true;
            this.mapaCiudades.RetryLoadTile = 0;
            this.mapaCiudades.RoutesEnabled = true;
            this.mapaCiudades.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapaCiudades.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapaCiudades.ShowTileGridLines = false;
            this.mapaCiudades.Size = new System.Drawing.Size(300, 236);
            this.mapaCiudades.TabIndex = 0;
            this.mapaCiudades.Zoom = 0D;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.barraProgresoCiudades);
            this.panel4.Controls.Add(this.butCargarCiudades);
            this.panel4.Controls.Add(this.txtCiudades);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.tablaCiudades);
            this.panel4.Location = new System.Drawing.Point(3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(417, 243);
            this.panel4.TabIndex = 0;
            // 
            // butCargarCiudades
            // 
            this.butCargarCiudades.BackColor = System.Drawing.SystemColors.Highlight;
            this.butCargarCiudades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCargarCiudades.ForeColor = System.Drawing.Color.White;
            this.butCargarCiudades.Location = new System.Drawing.Point(257, 4);
            this.butCargarCiudades.Name = "butCargarCiudades";
            this.butCargarCiudades.Size = new System.Drawing.Size(157, 39);
            this.butCargarCiudades.TabIndex = 3;
            this.butCargarCiudades.Text = "Cargar ciudades";
            this.butCargarCiudades.UseVisualStyleBackColor = false;
            this.butCargarCiudades.Click += new System.EventHandler(this.butCargarCiudades_Click);
            // 
            // txtCiudades
            // 
            this.txtCiudades.Location = new System.Drawing.Point(7, 23);
            this.txtCiudades.Name = "txtCiudades";
            this.txtCiudades.Size = new System.Drawing.Size(205, 20);
            this.txtCiudades.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visualizar pre-carga de ciudades:";
            // 
            // tablaCiudades
            // 
            this.tablaCiudades.AllowUserToAddRows = false;
            this.tablaCiudades.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tablaCiudades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCiudades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colPoblacion,
            this.colVer});
            this.tablaCiudades.EnableHeadersVisualStyles = false;
            this.tablaCiudades.Location = new System.Drawing.Point(4, 49);
            this.tablaCiudades.Name = "tablaCiudades";
            this.tablaCiudades.RowHeadersVisible = false;
            this.tablaCiudades.Size = new System.Drawing.Size(410, 140);
            this.tablaCiudades.TabIndex = 0;
            // 
            // colNombre
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNombre.DefaultCellStyle = dataGridViewCellStyle2;
            this.colNombre.Frozen = true;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 187;
            // 
            // colPoblacion
            // 
            this.colPoblacion.Frozen = true;
            this.colPoblacion.HeaderText = "Población";
            this.colPoblacion.Name = "colPoblacion";
            this.colPoblacion.Width = 150;
            // 
            // colVer
            // 
            this.colVer.HeaderText = "Ver";
            this.colVer.Name = "colVer";
            this.colVer.UseColumnTextForButtonValue = true;
            this.colVer.Width = 50;
            // 
            // barraProgresoCiudades
            // 
            this.barraProgresoCiudades.Location = new System.Drawing.Point(7, 195);
            this.barraProgresoCiudades.Name = "barraProgresoCiudades";
            this.barraProgresoCiudades.Size = new System.Drawing.Size(238, 23);
            this.barraProgresoCiudades.TabIndex = 4;
            // 
            // barraProgresoViajeros
            // 
            this.barraProgresoViajeros.Location = new System.Drawing.Point(4, 195);
            this.barraProgresoViajeros.Name = "barraProgresoViajeros";
            this.barraProgresoViajeros.Size = new System.Drawing.Size(238, 23);
            this.barraProgresoViajeros.TabIndex = 6;
            // 
            // InterfazCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InterfazCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de transporte del agente viajero (GTAV)";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaViajeros)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCiudades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button butCargarCiudades;
        private System.Windows.Forms.TextBox txtCiudades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private GMap.NET.WindowsForms.GMapControl mapaCiudades;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private GMap.NET.WindowsForms.GMapControl mapaViajeros;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button butCargarViajeros;
        private System.Windows.Forms.TextBox txtViajeros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tablaViajeros;
        private System.Windows.Forms.Button butSoluciones;
        private System.Windows.Forms.DataGridView tablaCiudades;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn colPreView;
        private System.Windows.Forms.DataGridViewButtonColumn colMapView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPoblacion;
        private System.Windows.Forms.DataGridViewButtonColumn colVer;
        private System.Windows.Forms.ProgressBar barraProgresoCiudades;
        private System.Windows.Forms.ProgressBar barraProgresoViajeros;
    }
}

