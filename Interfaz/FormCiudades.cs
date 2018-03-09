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
    public partial class FormCiudades : Form
    {
        public FormCiudades()
        {
            InitializeComponent();
        }

        public FormCiudades(List<String> ciudades)
        {
            InitializeComponent();
            foreach(String ciudad in ciudades)
            {
                listBox1.Items.Add(ciudad);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Dispose();
            }
        }
    }
}
