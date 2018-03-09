namespace GTAV
{
    partial class InterfazSolucion
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
            this.tablaViajeros = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCiudades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMapa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labPagina = new System.Windows.Forms.Label();
            this.butSiguiente = new System.Windows.Forms.Button();
            this.butAnterior = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.butParar = new System.Windows.Forms.Button();
            this.butIniciar = new System.Windows.Forms.Button();
            this.rbMetodo3 = new System.Windows.Forms.RadioButton();
            this.rbMetodo2 = new System.Windows.Forms.RadioButton();
            this.rbMetodo1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablaViajeros)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablaViajeros
            // 
            this.tablaViajeros.AllowUserToAddRows = false;
            this.tablaViajeros.AllowUserToDeleteRows = false;
            this.tablaViajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaViajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colCiudades,
            this.colMapa});
            this.tablaViajeros.Location = new System.Drawing.Point(13, 36);
            this.tablaViajeros.Name = "tablaViajeros";
            this.tablaViajeros.ReadOnly = true;
            this.tablaViajeros.RowHeadersVisible = false;
            this.tablaViajeros.Size = new System.Drawing.Size(445, 150);
            this.tablaViajeros.TabIndex = 0;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 120;
            // 
            // colCiudades
            // 
            this.colCiudades.HeaderText = "Ciudades";
            this.colCiudades.Name = "colCiudades";
            this.colCiudades.ReadOnly = true;
            // 
            // colMapa
            // 
            this.colMapa.HeaderText = "Mapa";
            this.colMapa.Name = "colMapa";
            this.colMapa.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tablaViajeros);
            this.panel1.Location = new System.Drawing.Point(13, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 210);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de viajeros:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labPagina);
            this.panel2.Controls.Add(this.butSiguiente);
            this.panel2.Controls.Add(this.butAnterior);
            this.panel2.Location = new System.Drawing.Point(180, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 40);
            this.panel2.TabIndex = 2;
            // 
            // labPagina
            // 
            this.labPagina.AutoSize = true;
            this.labPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPagina.Location = new System.Drawing.Point(57, 8);
            this.labPagina.Name = "labPagina";
            this.labPagina.Size = new System.Drawing.Size(30, 25);
            this.labPagina.TabIndex = 2;
            this.labPagina.Text = "...";
            this.labPagina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butSiguiente
            // 
            this.butSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSiguiente.Location = new System.Drawing.Point(100, 1);
            this.butSiguiente.Name = "butSiguiente";
            this.butSiguiente.Size = new System.Drawing.Size(40, 37);
            this.butSiguiente.TabIndex = 1;
            this.butSiguiente.Text = ">";
            this.butSiguiente.UseVisualStyleBackColor = true;
            // 
            // butAnterior
            // 
            this.butAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAnterior.Location = new System.Drawing.Point(3, 1);
            this.butAnterior.Name = "butAnterior";
            this.butAnterior.Size = new System.Drawing.Size(40, 37);
            this.butAnterior.TabIndex = 0;
            this.butAnterior.Text = "<";
            this.butAnterior.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.butParar);
            this.panel3.Controls.Add(this.butIniciar);
            this.panel3.Controls.Add(this.rbMetodo3);
            this.panel3.Controls.Add(this.rbMetodo2);
            this.panel3.Controls.Add(this.rbMetodo1);
            this.panel3.Location = new System.Drawing.Point(113, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 63);
            this.panel3.TabIndex = 3;
            // 
            // butParar
            // 
            this.butParar.BackColor = System.Drawing.Color.Red;
            this.butParar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butParar.ForeColor = System.Drawing.Color.White;
            this.butParar.Location = new System.Drawing.Point(126, 27);
            this.butParar.Name = "butParar";
            this.butParar.Size = new System.Drawing.Size(75, 31);
            this.butParar.TabIndex = 4;
            this.butParar.Text = "Parar";
            this.butParar.UseVisualStyleBackColor = false;
            // 
            // butIniciar
            // 
            this.butIniciar.BackColor = System.Drawing.Color.Lime;
            this.butIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butIniciar.ForeColor = System.Drawing.Color.White;
            this.butIniciar.Location = new System.Drawing.Point(45, 27);
            this.butIniciar.Name = "butIniciar";
            this.butIniciar.Size = new System.Drawing.Size(75, 31);
            this.butIniciar.TabIndex = 3;
            this.butIniciar.Text = "Iniciar";
            this.butIniciar.UseVisualStyleBackColor = false;
            // 
            // rbMetodo3
            // 
            this.rbMetodo3.AutoSize = true;
            this.rbMetodo3.Location = new System.Drawing.Point(167, 4);
            this.rbMetodo3.Name = "rbMetodo3";
            this.rbMetodo3.Size = new System.Drawing.Size(70, 17);
            this.rbMetodo3.TabIndex = 2;
            this.rbMetodo3.TabStop = true;
            this.rbMetodo3.Text = "Método 3";
            this.rbMetodo3.UseVisualStyleBackColor = true;
            // 
            // rbMetodo2
            // 
            this.rbMetodo2.AutoSize = true;
            this.rbMetodo2.Location = new System.Drawing.Point(90, 4);
            this.rbMetodo2.Name = "rbMetodo2";
            this.rbMetodo2.Size = new System.Drawing.Size(70, 17);
            this.rbMetodo2.TabIndex = 1;
            this.rbMetodo2.TabStop = true;
            this.rbMetodo2.Text = "Método 2";
            this.rbMetodo2.UseVisualStyleBackColor = true;
            // 
            // rbMetodo1
            // 
            this.rbMetodo1.AutoSize = true;
            this.rbMetodo1.Checked = true;
            this.rbMetodo1.Location = new System.Drawing.Point(13, 4);
            this.rbMetodo1.Name = "rbMetodo1";
            this.rbMetodo1.Size = new System.Drawing.Size(70, 17);
            this.rbMetodo1.TabIndex = 0;
            this.rbMetodo1.TabStop = true;
            this.rbMetodo1.Text = "Método 1";
            this.rbMetodo1.UseVisualStyleBackColor = true;
            // 
            // InterfazSoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 342);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InterfazSoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soluciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InterfazSoluciones_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.tablaViajeros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView tablaViajeros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labPagina;
        private System.Windows.Forms.Button butSiguiente;
        private System.Windows.Forms.Button butAnterior;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbMetodo1;
        private System.Windows.Forms.Button butParar;
        private System.Windows.Forms.Button butIniciar;
        private System.Windows.Forms.RadioButton rbMetodo3;
        private System.Windows.Forms.RadioButton rbMetodo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCiudades;
        private System.Windows.Forms.DataGridViewButtonColumn colMapa;
    }
}