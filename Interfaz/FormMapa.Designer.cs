namespace Interfaz
{
    partial class FormMapa
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
            this.mapa = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labCiudadInicio = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.labCodigo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listaCiudades = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbMostrarRutas = new System.Windows.Forms.CheckBox();
            this.cbMostrarCiudades = new System.Windows.Forms.CheckBox();
            this.butRegresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapa
            // 
            this.mapa.Bearing = 0F;
            this.mapa.CanDragMap = true;
            this.mapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapa.GrayScaleMode = false;
            this.mapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapa.LevelsKeepInMemmory = 5;
            this.mapa.Location = new System.Drawing.Point(277, 13);
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
            this.mapa.Size = new System.Drawing.Size(548, 412);
            this.mapa.TabIndex = 0;
            this.mapa.Zoom = 0D;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.labCiudadInicio);
            this.groupBox1.Controls.Add(this.labNombre);
            this.groupBox1.Controls.Add(this.labCodigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del viajero";
            // 
            // labCiudadInicio
            // 
            this.labCiudadInicio.AutoSize = true;
            this.labCiudadInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCiudadInicio.Location = new System.Drawing.Point(114, 75);
            this.labCiudadInicio.Name = "labCiudadInicio";
            this.labCiudadInicio.Size = new System.Drawing.Size(17, 16);
            this.labCiudadInicio.TabIndex = 5;
            this.labCiudadInicio.Text = "...";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.Location = new System.Drawing.Point(79, 51);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(17, 16);
            this.labNombre.TabIndex = 4;
            this.labNombre.Text = "...";
            // 
            // labCodigo
            // 
            this.labCodigo.AutoSize = true;
            this.labCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCodigo.Location = new System.Drawing.Point(74, 27);
            this.labCodigo.Name = "labCodigo";
            this.labCodigo.Size = new System.Drawing.Size(17, 16);
            this.labCodigo.TabIndex = 3;
            this.labCodigo.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ciudad inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.listaCiudades);
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 154);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de ciudades";
            // 
            // listaCiudades
            // 
            this.listaCiudades.FormattingEnabled = true;
            this.listaCiudades.Location = new System.Drawing.Point(9, 20);
            this.listaCiudades.Name = "listaCiudades";
            this.listaCiudades.Size = new System.Drawing.Size(244, 121);
            this.listaCiudades.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.cbMostrarRutas);
            this.groupBox3.Controls.Add(this.cbMostrarCiudades);
            this.groupBox3.Location = new System.Drawing.Point(12, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 67);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones mapa";
            // 
            // cbMostrarRutas
            // 
            this.cbMostrarRutas.AutoSize = true;
            this.cbMostrarRutas.Location = new System.Drawing.Point(9, 43);
            this.cbMostrarRutas.Name = "cbMostrarRutas";
            this.cbMostrarRutas.Size = new System.Drawing.Size(87, 17);
            this.cbMostrarRutas.TabIndex = 1;
            this.cbMostrarRutas.Text = "Mostrar rutas";
            this.cbMostrarRutas.UseVisualStyleBackColor = true;
            this.cbMostrarRutas.CheckedChanged += new System.EventHandler(this.cbMostrarRutas_CheckedChanged);
            // 
            // cbMostrarCiudades
            // 
            this.cbMostrarCiudades.AutoSize = true;
            this.cbMostrarCiudades.Location = new System.Drawing.Point(9, 20);
            this.cbMostrarCiudades.Name = "cbMostrarCiudades";
            this.cbMostrarCiudades.Size = new System.Drawing.Size(107, 17);
            this.cbMostrarCiudades.TabIndex = 0;
            this.cbMostrarCiudades.Text = "Mostrar ciudades";
            this.cbMostrarCiudades.UseVisualStyleBackColor = true;
            this.cbMostrarCiudades.CheckedChanged += new System.EventHandler(this.cbMostrarCiudades_CheckedChanged);
            // 
            // butRegresar
            // 
            this.butRegresar.BackColor = System.Drawing.Color.DodgerBlue;
            this.butRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRegresar.ForeColor = System.Drawing.Color.White;
            this.butRegresar.Location = new System.Drawing.Point(12, 355);
            this.butRegresar.Name = "butRegresar";
            this.butRegresar.Size = new System.Drawing.Size(259, 70);
            this.butRegresar.TabIndex = 4;
            this.butRegresar.Text = "Regresar";
            this.butRegresar.UseVisualStyleBackColor = false;
            this.butRegresar.Click += new System.EventHandler(this.butRegresar_Click);
            // 
            // FormMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 437);
            this.Controls.Add(this.butRegresar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mapa);
            this.Name = "FormMapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualización de la solución";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMapa_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mapa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labCiudadInicio;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Label labCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listaCiudades;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbMostrarRutas;
        private System.Windows.Forms.CheckBox cbMostrarCiudades;
        private System.Windows.Forms.Button butRegresar;
    }
}