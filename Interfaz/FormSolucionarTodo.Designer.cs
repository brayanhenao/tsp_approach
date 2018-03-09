namespace Interfaz
{
    partial class FormSolucionarTodo
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
            this.rbFuerzaBruta = new System.Windows.Forms.RadioButton();
            this.rbKruskal = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.picGif = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tablaViajeros = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMapView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labPorcentaje = new System.Windows.Forms.Label();
            this.rbInsercion = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGif)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaViajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbInsercion);
            this.panel1.Controls.Add(this.rbFuerzaBruta);
            this.panel1.Controls.Add(this.rbKruskal);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.picGif);
            this.panel1.Location = new System.Drawing.Point(66, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 70);
            this.panel1.TabIndex = 0;
            // 
            // rbFuerzaBruta
            // 
            this.rbFuerzaBruta.AutoSize = true;
            this.rbFuerzaBruta.Location = new System.Drawing.Point(3, 27);
            this.rbFuerzaBruta.Name = "rbFuerzaBruta";
            this.rbFuerzaBruta.Size = new System.Drawing.Size(126, 17);
            this.rbFuerzaBruta.TabIndex = 4;
            this.rbFuerzaBruta.TabStop = true;
            this.rbFuerzaBruta.Text = "Exploración completa";
            this.rbFuerzaBruta.UseVisualStyleBackColor = true;
            // 
            // rbKruskal
            // 
            this.rbKruskal.AutoSize = true;
            this.rbKruskal.Location = new System.Drawing.Point(4, 4);
            this.rbKruskal.Name = "rbKruskal";
            this.rbKruskal.Size = new System.Drawing.Size(108, 17);
            this.rbKruskal.TabIndex = 3;
            this.rbKruskal.TabStop = true;
            this.rbKruskal.Text = "Kruskal PreOrden";
            this.rbKruskal.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(135, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picGif
            // 
            this.picGif.Image = global::Interfaz.Properties.Resources.loading;
            this.picGif.Location = new System.Drawing.Point(260, 10);
            this.picGif.Name = "picGif";
            this.picGif.Size = new System.Drawing.Size(48, 48);
            this.picGif.TabIndex = 1;
            this.picGif.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.tablaViajeros);
            this.panel2.Location = new System.Drawing.Point(13, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 248);
            this.panel2.TabIndex = 1;
            // 
            // tablaViajeros
            // 
            this.tablaViajeros.AllowUserToAddRows = false;
            this.tablaViajeros.AllowUserToDeleteRows = false;
            this.tablaViajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaViajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colMapView});
            this.tablaViajeros.Location = new System.Drawing.Point(4, 3);
            this.tablaViajeros.Name = "tablaViajeros";
            this.tablaViajeros.ReadOnly = true;
            this.tablaViajeros.RowHeadersVisible = false;
            this.tablaViajeros.Size = new System.Drawing.Size(455, 253);
            this.tablaViajeros.TabIndex = 0;
            this.tablaViajeros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaViajeros_CellClick_1);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 150;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 175;
            // 
            // colMapView
            // 
            this.colMapView.HeaderText = "Soluciones";
            this.colMapView.Name = "colMapView";
            this.colMapView.ReadOnly = true;
            this.colMapView.Text = "Ver";
            this.colMapView.ToolTipText = "Ver";
            this.colMapView.UseColumnTextForButtonValue = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 352);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(464, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // labPorcentaje
            // 
            this.labPorcentaje.AutoSize = true;
            this.labPorcentaje.Location = new System.Drawing.Point(219, 386);
            this.labPorcentaje.Name = "labPorcentaje";
            this.labPorcentaje.Size = new System.Drawing.Size(21, 13);
            this.labPorcentaje.TabIndex = 3;
            this.labPorcentaje.Text = "0%";
            // 
            // rbInsercion
            // 
            this.rbInsercion.AutoSize = true;
            this.rbInsercion.Location = new System.Drawing.Point(4, 48);
            this.rbInsercion.Name = "rbInsercion";
            this.rbInsercion.Size = new System.Drawing.Size(68, 17);
            this.rbInsercion.TabIndex = 5;
            this.rbInsercion.TabStop = true;
            this.rbInsercion.Text = "Inserción";
            this.rbInsercion.UseVisualStyleBackColor = true;
            // 
            // FormSolucionarTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 408);
            this.Controls.Add(this.labPorcentaje);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormSolucionarTodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar todas las soluciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSolucionarTodo_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGif)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaViajeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tablaViajeros;
        private System.Windows.Forms.DataGridViewButtonColumn colMapView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.PictureBox picGif;
        private System.Windows.Forms.Button butIniciar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbFuerzaBruta;
        private System.Windows.Forms.RadioButton rbKruskal;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labPorcentaje;
        private System.Windows.Forms.RadioButton rbInsercion;
    }
}