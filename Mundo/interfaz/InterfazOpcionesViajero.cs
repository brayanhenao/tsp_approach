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
    public partial class InterfazOpcionesViajero : Form
    {
        //Atributos
        private InterfazCarga principal;
        private InterfazMapa interfazMapa;

        //Constructor
        public InterfazOpcionesViajero(InterfazCarga interfaz, String codigo, String nombre)
        {
            InitializeComponent();
            this.principal = interfaz;
            this.labCodigo.Text = codigo;
            this.labNombre.Text = nombre;
            cargarInformacion();
        }

        /* Descripción: Este método carga la lista de ciudades de un viajero e información necesaria para darle
        *  un itinerario a traves de una de las 3 opciones de la parte inferior de la interfaz.
        */
        private void cargarInformacion()
        {

        }

        /* Descripción: Evento generado al cerrarse la ventana
        */
        private void InterfazOpciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Enabled = true;
            this.Dispose();
        }
    }
}
