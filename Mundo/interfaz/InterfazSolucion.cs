using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTAV
{
    public partial class InterfazSolucion : Form
    {
        //Atributos
        private InterfazCarga principal;
        private InterfazMapa interfazMapa;

        //Constructor
        public InterfazSolucion(InterfazCarga interfaz)
        {
            InitializeComponent();
            principal = interfaz;
        }

        /* Descripción: Evento generado al cerrarse la ventana
    */
        private void InterfazSoluciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Enabled = true;
            this.Dispose();

        }
    }
}
