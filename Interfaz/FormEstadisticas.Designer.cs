namespace Interfaz
{
    partial class FormEstadisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.chartKruskal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.chartFuerzaBruta = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartInsercion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartKruskal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFuerzaBruta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInsercion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solución por Kruskal MTS";
            // 
            // chartKruskal
            // 
            chartArea4.AxisX.Title = "Ciudades";
            chartArea4.AxisY.Title = "Tiempo(Segundos)";
            chartArea4.Name = "ChartArea1";
            this.chartKruskal.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartKruskal.Legends.Add(legend4);
            this.chartKruskal.Location = new System.Drawing.Point(2, 42);
            this.chartKruskal.Name = "chartKruskal";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.XValueMember = "2";
            series4.YValueMembers = "3";
            this.chartKruskal.Series.Add(series4);
            this.chartKruskal.Size = new System.Drawing.Size(391, 232);
            this.chartKruskal.TabIndex = 1;
            this.chartKruskal.Text = "chartKruskal";
            this.chartKruskal.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(495, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Solución por fuerza bruta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chartFuerzaBruta
            // 
            chartArea5.AxisX.Title = "Ciudades";
            chartArea5.AxisY.Title = "Tiempo(Segundos)";
            chartArea5.Name = "ChartArea1";
            this.chartFuerzaBruta.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartFuerzaBruta.Legends.Add(legend5);
            this.chartFuerzaBruta.Location = new System.Drawing.Point(399, 42);
            this.chartFuerzaBruta.Name = "chartFuerzaBruta";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartFuerzaBruta.Series.Add(series5);
            this.chartFuerzaBruta.Size = new System.Drawing.Size(391, 232);
            this.chartFuerzaBruta.TabIndex = 3;
            this.chartFuerzaBruta.Text = "chartFuerzaBruta";
            this.chartFuerzaBruta.Click += new System.EventHandler(this.chart2_Click);
            // 
            // chartInsercion
            // 
            chartArea6.AxisX.Title = "Ciudades";
            chartArea6.AxisY.Title = "Tiempo(Segundos)";
            chartArea6.Name = "ChartArea1";
            this.chartInsercion.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartInsercion.Legends.Add(legend6);
            this.chartInsercion.Location = new System.Drawing.Point(796, 42);
            this.chartInsercion.Name = "chartInsercion";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartInsercion.Series.Add(series6);
            this.chartInsercion.Size = new System.Drawing.Size(391, 232);
            this.chartInsercion.TabIndex = 4;
            this.chartInsercion.Text = "chartInsercion";
            this.chartInsercion.Click += new System.EventHandler(this.chart3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(837, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Solución Algoritmo insercion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(95, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(468, 172);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(569, 295);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(468, 172);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // FormEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 490);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartInsercion);
            this.Controls.Add(this.chartFuerzaBruta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chartKruskal);
            this.Controls.Add(this.label1);
            this.Name = "FormEstadisticas";
            ((System.ComponentModel.ISupportInitialize)(this.chartKruskal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFuerzaBruta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInsercion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKruskal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFuerzaBruta;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInsercion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}