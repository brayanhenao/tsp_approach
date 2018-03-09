namespace GTAV
{
    partial class InterfazMapa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.butRegresar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labCantidadRutas = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labCantidadCiudades = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbMostrarRutas = new System.Windows.Forms.RadioButton();
            this.rbMostrarCiudades = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listaCiudades = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labCiudadInicio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labCodigo = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mapa = new GMap.NET.WindowsForms.GMapControl();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.butRegresar);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 403);
            this.panel1.TabIndex = 0;
            // 
            // butRegresar
            // 
            this.butRegresar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.butRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRegresar.ForeColor = System.Drawing.Color.White;
            this.butRegresar.Location = new System.Drawing.Point(4, 351);
            this.butRegresar.Name = "butRegresar";
            this.butRegresar.Size = new System.Drawing.Size(215, 49);
            this.butRegresar.TabIndex = 2;
            this.butRegresar.Text = "Regresar";
            this.butRegresar.UseVisualStyleBackColor = false;
            this.butRegresar.Click += new System.EventHandler(this.butRegresar_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.labCantidadRutas);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.labCantidadCiudades);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(4, 205);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(215, 64);
            this.panel5.TabIndex = 3;
            // 
            // labCantidadRutas
            // 
            this.labCantidadRutas.AutoSize = true;
            this.labCantidadRutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCantidadRutas.Location = new System.Drawing.Point(149, 37);
            this.labCantidadRutas.Name = "labCantidadRutas";
            this.labCantidadRutas.Size = new System.Drawing.Size(21, 20);
            this.labCantidadRutas.TabIndex = 3;
            this.labCantidadRutas.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Cantidad de rutas:";
            // 
            // labCantidadCiudades
            // 
            this.labCantidadCiudades.AutoSize = true;
            this.labCantidadCiudades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCantidadCiudades.Location = new System.Drawing.Point(177, 11);
            this.labCantidadCiudades.Name = "labCantidadCiudades";
            this.labCantidadCiudades.Size = new System.Drawing.Size(21, 20);
            this.labCantidadCiudades.TabIndex = 1;
            this.labCantidadCiudades.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cantidad de ciudades:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.rbMostrarRutas);
            this.panel4.Controls.Add(this.rbMostrarCiudades);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(3, 275);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 70);
            this.panel4.TabIndex = 2;
            // 
            // rbMostrarRutas
            // 
            this.rbMostrarRutas.AutoSize = true;
            this.rbMostrarRutas.Location = new System.Drawing.Point(8, 44);
            this.rbMostrarRutas.Name = "rbMostrarRutas";
            this.rbMostrarRutas.Size = new System.Drawing.Size(86, 17);
            this.rbMostrarRutas.TabIndex = 3;
            this.rbMostrarRutas.TabStop = true;
            this.rbMostrarRutas.Text = "Mostrar rutas";
            this.rbMostrarRutas.UseVisualStyleBackColor = true;
            // 
            // rbMostrarCiudades
            // 
            this.rbMostrarCiudades.AutoSize = true;
            this.rbMostrarCiudades.Location = new System.Drawing.Point(7, 21);
            this.rbMostrarCiudades.Name = "rbMostrarCiudades";
            this.rbMostrarCiudades.Size = new System.Drawing.Size(106, 17);
            this.rbMostrarCiudades.TabIndex = 2;
            this.rbMostrarCiudades.TabStop = true;
            this.rbMostrarCiudades.Text = "Mostrar ciudades";
            this.rbMostrarCiudades.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Opciones del mapa:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.listaCiudades);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(4, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 100);
            this.panel3.TabIndex = 1;
            // 
            // listaCiudades
            // 
            this.listaCiudades.FormattingEnabled = true;
            this.listaCiudades.Location = new System.Drawing.Point(7, 21);
            this.listaCiudades.Name = "listaCiudades";
            this.listaCiudades.Size = new System.Drawing.Size(205, 69);
            this.listaCiudades.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lista de ciudades:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.labCiudadInicio);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labCodigo);
            this.panel2.Controls.Add(this.labNombre);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 87);
            this.panel2.TabIndex = 0;
            // 
            // labCiudadInicio
            // 
            this.labCiudadInicio.AutoSize = true;
            this.labCiudadInicio.Location = new System.Drawing.Point(96, 54);
            this.labCiudadInicio.Name = "labCiudadInicio";
            this.labCiudadInicio.Size = new System.Drawing.Size(16, 13);
            this.labCiudadInicio.TabIndex = 5;
            this.labCiudadInicio.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ciudad de inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código:";
            // 
            // labCodigo
            // 
            this.labCodigo.AutoSize = true;
            this.labCodigo.Location = new System.Drawing.Point(53, 35);
            this.labCodigo.Name = "labCodigo";
            this.labCodigo.Size = new System.Drawing.Size(16, 13);
            this.labCodigo.TabIndex = 2;
            this.labCodigo.Text = "...";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(57, 15);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(16, 13);
            this.labNombre.TabIndex = 1;
            this.labNombre.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // mapa
            // 
            this.mapa.Bearing = 0F;
            this.mapa.CanDragMap = true;
            this.mapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapa.GrayScaleMode = false;
            this.mapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapa.LevelsKeepInMemmory = 5;
            this.mapa.Location = new System.Drawing.Point(3, 4);
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
            this.mapa.Size = new System.Drawing.Size(469, 393);
            this.mapa.TabIndex = 1;
            this.mapa.Zoom = 0D;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Controls.Add(this.mapa);
            this.panel6.Location = new System.Drawing.Point(243, 13);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(475, 400);
            this.panel6.TabIndex = 2;
            // 
            // InterfazMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 428);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InterfazMapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualización del mapa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InterfazMapa_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listaCiudades;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labCiudadInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labCodigo;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbMostrarRutas;
        private System.Windows.Forms.RadioButton rbMostrarCiudades;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labCantidadRutas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labCantidadCiudades;
        private System.Windows.Forms.Label label6;
        private GMap.NET.WindowsForms.GMapControl mapa;
        private System.Windows.Forms.Button butRegresar;
        private System.Windows.Forms.Panel panel6;
    }
}