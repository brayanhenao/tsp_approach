using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FormEstadisticas : Form
    {
        private FormCargar principal;

        public FormEstadisticas(FormCargar principal)
        {
            this.principal = principal;
            InitializeComponent();
            crearGrafico();
            crearTablas();
        }
        public void crearGrafico()
        {
            chartFuerzaBruta.Series.Clear();
            chartFuerzaBruta.Series.Add("Tiempo");
            chartFuerzaBruta.Series["Tiempo"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chartFuerzaBruta.Series["Tiempo"].Points.AddXY(1, 0.0000053);
            chartFuerzaBruta.Series["Tiempo"].Points.AddXY(2, 0.0000303);
            chartFuerzaBruta.Series["Tiempo"].Points.AddXY(3, 0.0000147);
            chartFuerzaBruta.Series["Tiempo"].Points.AddXY(4, 0.0000232);
            chartFuerzaBruta.Series["Tiempo"].Points.AddXY(5, 0.0004609);
            chartFuerzaBruta.Series["Tiempo"].Points.AddXY(6, 0.0006550);
            chartFuerzaBruta.Series["Tiempo"].Points.AddXY(7, 0.0047409);
            chartFuerzaBruta.Series["Tiempo"].Points.AddXY(8, 0.0267364);
            chartFuerzaBruta.Series["Tiempo"].Points.AddXY(9, 0.2596637);
            chartFuerzaBruta.Series["Tiempo"].Points.AddXY(10, 2.6135904);
            chartFuerzaBruta.Series["Tiempo"].Points.AddXY(11, 29.6865148);
            chartFuerzaBruta.Series["Tiempo"].Points.AddXY(12, 59.7990677);
            chartFuerzaBruta.Series["Tiempo"].Points.AddXY(13, 3654);
            chartFuerzaBruta.Series["Tiempo"].Points.AddXY(14, 30600);

            chartKruskal.Series.Clear();
            chartKruskal.Series.Add("Tiempo");
            chartKruskal.Series["Tiempo"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chartKruskal.Series["Tiempo"].Points.AddXY(1, 0.0000026);
            chartKruskal.Series["Tiempo"].Points.AddXY(2, 0.0000093);
            chartKruskal.Series["Tiempo"].Points.AddXY(3, 0.0000218);
            chartKruskal.Series["Tiempo"].Points.AddXY(4, 0.0000339);
            chartKruskal.Series["Tiempo"].Points.AddXY(5, 0.0000339);
            chartKruskal.Series["Tiempo"].Points.AddXY(6, 0.0000349);
            chartKruskal.Series["Tiempo"].Points.AddXY(7, 0.0000397);
            chartKruskal.Series["Tiempo"].Points.AddXY(8, 0.0000593);
            chartKruskal.Series["Tiempo"].Points.AddXY(9, 0.0000812);
            chartKruskal.Series["Tiempo"].Points.AddXY(10, 0.0000852);
            chartKruskal.Series["Tiempo"].Points.AddXY(11, 0.0000896);
            chartKruskal.Series["Tiempo"].Points.AddXY(12, 0.0001633);
            chartKruskal.Series["Tiempo"].Points.AddXY(13, 0.0001994);
            chartKruskal.Series["Tiempo"].Points.AddXY(14, 0.0002397);

            chartInsercion.Series.Clear();
            chartInsercion.Series.Add("Tiempo");
            chartInsercion.Series["Tiempo"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chartInsercion.Series["Tiempo"].Points.AddXY(1, 0.0000036);
            chartInsercion.Series["Tiempo"].Points.AddXY(2, 0.0000094);
            chartInsercion.Series["Tiempo"].Points.AddXY(3, 0.0000139);
            chartInsercion.Series["Tiempo"].Points.AddXY(4, 0.0000160);
            chartInsercion.Series["Tiempo"].Points.AddXY(5, 0.0000160);
            chartInsercion.Series["Tiempo"].Points.AddXY(6, 0.0000197);
            chartInsercion.Series["Tiempo"].Points.AddXY(7, 0.0000238);
            chartInsercion.Series["Tiempo"].Points.AddXY(8, 0.0000369);
            chartInsercion.Series["Tiempo"].Points.AddXY(9, 0.0000357);
            chartInsercion.Series["Tiempo"].Points.AddXY(10, 0.0000473);
            chartInsercion.Series["Tiempo"].Points.AddXY(11, 0.0000570);
            chartInsercion.Series["Tiempo"].Points.AddXY(12, 0.0000521);
            chartInsercion.Series["Tiempo"].Points.AddXY(13, 00.0000759);
            chartInsercion.Series["Tiempo"].Points.AddXY(14, 0.0000983);
        }
        public void crearTablas()
        {
            dataGridView1.Columns.Add("Cantidad", "Cantidad de ciudades");
            dataGridView1.Columns.Add("Resultado", "Distancia Kruskal");
            dataGridView1.Columns.Add("Exacto", "Distancia Exacta");
            dataGridView1.Columns.Add("Error", "Error");
            dataGridView1.Rows.Add(1, 0 , 0,"0%");
            dataGridView1.Rows.Add(2, 330  , 330, "0%");
            dataGridView1.Rows.Add(3, 5069 ,  5069, "0%");
            dataGridView1.Rows.Add(4, 7007 , 699, "0,16%");
            dataGridView1.Rows.Add(5, 6722  , 6699, "0,34%");
            dataGridView1.Rows.Add(6, 13204 ,12382, "6,64");
            dataGridView1.Rows.Add(7, 27850 , 27850, "0%");
            dataGridView1.Rows.Add(8, 33890 , 28782, "17,75%");
            dataGridView1.Rows.Add(9, 37583 , 37239, "0,92%");
            dataGridView1.Rows.Add(10, 37803 ,37687, "0,31%");
            dataGridView1.Rows.Add(11, 39170  ,  37789, "3,65");
            dataGridView1.Rows.Add("Promedio de error", "", "", "2,71%");

            dataGridView2.Columns.Add("Cantidad", "Cantidad de ciudades");
            dataGridView2.Columns.Add("Resultado", "Distancia Insercion");
            dataGridView2.Columns.Add("Exacto", "Distancia Exacta");
            dataGridView2.Columns.Add("Error", "Error");
            dataGridView2.Rows.Add(1, 0, 0, "0%");
            dataGridView2.Rows.Add(2, 330, 330, "0%");
            dataGridView2.Rows.Add(3, 5069, 5069, "0%");
            dataGridView2.Rows.Add(4, 6996, 6996, "0%");
            dataGridView2.Rows.Add(5, 6699, 6699, "0%");
            dataGridView2.Rows.Add(6, 16267, 12382, "31,4%");
            dataGridView2.Rows.Add(7, 36387, 27850, "30,7%");
            dataGridView2.Rows.Add(8, 52188, 28782, "81,3%");
            dataGridView2.Rows.Add(9, 52031, 37239, "39,7%");
            dataGridView2.Rows.Add(10, 38066, 37687, "1%");
            dataGridView2.Rows.Add(11, 66274, 37789, "75,4%");
            dataGridView2.Rows.Add("Promedio de error", "", "", "23,6%");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
