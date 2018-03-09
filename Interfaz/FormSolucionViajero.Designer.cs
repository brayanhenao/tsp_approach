namespace Interfaz
{
    partial class FormSolucionViajero
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
            this.labCiudadInicio = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.labCodigo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbInsercion = new System.Windows.Forms.RadioButton();
            this.rbFuerzaBruta = new System.Windows.Forms.RadioButton();
            this.rbKruskal = new System.Windows.Forms.RadioButton();
            this.butSolucion = new System.Windows.Forms.Button();
            this.workFuerzaBruta = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPoblacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gifCargando = new System.Windows.Forms.PictureBox();
            this.workInsercion = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gifCargando)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 100);
            this.groupBox1.TabIndex = 0;
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
            this.groupBox2.Controls.Add(this.rbInsercion);
            this.groupBox2.Controls.Add(this.rbFuerzaBruta);
            this.groupBox2.Controls.Add(this.rbKruskal);
            this.groupBox2.Location = new System.Drawing.Point(13, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipos de solución:";
            // 
            // rbInsercion
            // 
            this.rbInsercion.AutoSize = true;
            this.rbInsercion.Location = new System.Drawing.Point(9, 67);
            this.rbInsercion.Name = "rbInsercion";
            this.rbInsercion.Size = new System.Drawing.Size(112, 17);
            this.rbInsercion.TabIndex = 2;
            this.rbInsercion.TabStop = true;
            this.rbInsercion.Text = "Solución Inserción";
            this.rbInsercion.UseVisualStyleBackColor = true;
            // 
            // rbFuerzaBruta
            // 
            this.rbFuerzaBruta.AutoSize = true;
            this.rbFuerzaBruta.Location = new System.Drawing.Point(9, 44);
            this.rbFuerzaBruta.Name = "rbFuerzaBruta";
            this.rbFuerzaBruta.Size = new System.Drawing.Size(129, 17);
            this.rbFuerzaBruta.TabIndex = 1;
            this.rbFuerzaBruta.TabStop = true;
            this.rbFuerzaBruta.Text = "Solución Fuerza Bruta";
            this.rbFuerzaBruta.UseVisualStyleBackColor = true;
            // 
            // rbKruskal
            // 
            this.rbKruskal.AutoSize = true;
            this.rbKruskal.Checked = true;
            this.rbKruskal.Location = new System.Drawing.Point(9, 20);
            this.rbKruskal.Name = "rbKruskal";
            this.rbKruskal.Size = new System.Drawing.Size(173, 17);
            this.rbKruskal.TabIndex = 0;
            this.rbKruskal.TabStop = true;
            this.rbKruskal.Text = "Solución Kruskal con PreOrden";
            this.rbKruskal.UseVisualStyleBackColor = true;
            // 
            // butSolucion
            // 
            this.butSolucion.BackColor = System.Drawing.Color.DodgerBlue;
            this.butSolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSolucion.ForeColor = System.Drawing.Color.White;
            this.butSolucion.Location = new System.Drawing.Point(12, 301);
            this.butSolucion.Name = "butSolucion";
            this.butSolucion.Size = new System.Drawing.Size(259, 54);
            this.butSolucion.TabIndex = 2;
            this.butSolucion.Text = "Solucionar";
            this.butSolucion.UseVisualStyleBackColor = false;
            this.butSolucion.Click += new System.EventHandler(this.butSolucion_Click);
            // 
            // workFuerzaBruta
            // 
            this.workFuerzaBruta.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workFuerzaBruta_DoWork);
            this.workFuerzaBruta.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workFuerzaBruta_RunWorkerCompleted);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txtPoblacion);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 75);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtrar ciudades:";
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.Location = new System.Drawing.Point(10, 43);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(243, 20);
            this.txtPoblacion.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ciudades con población mayor a:";
            // 
            // gifCargando
            // 
            this.gifCargando.Location = new System.Drawing.Point(29, 64);
            this.gifCargando.Name = "gifCargando";
            this.gifCargando.Size = new System.Drawing.Size(220, 220);
            this.gifCargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gifCargando.TabIndex = 16;
            this.gifCargando.TabStop = false;
            // 
            // workInsercion
            // 
            this.workInsercion.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workInsercion_DoWork);
            this.workInsercion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workInsercion_RunWorkerCompleted);
            // 
            // FormSolucionViajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(286, 358);
            this.Controls.Add(this.gifCargando);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.butSolucion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSolucionViajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar ruta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSolucionesViajero_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gifCargando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labCiudadInicio;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Label labCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbInsercion;
        private System.Windows.Forms.RadioButton rbFuerzaBruta;
        private System.Windows.Forms.RadioButton rbKruskal;
        private System.Windows.Forms.Button butSolucion;
        private System.ComponentModel.BackgroundWorker workFuerzaBruta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPoblacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox gifCargando;
        private System.ComponentModel.BackgroundWorker workInsercion;
    }
}