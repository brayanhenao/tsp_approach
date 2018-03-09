using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTAV
{
    public partial class InterfazMapa : Form
    {
        //Atributos
        private InterfazCarga principal;

        //Constructor
        public InterfazMapa(InterfazCarga interfaz, String nombre, String codigo)
        {
            InitializeComponent();
            principal = interfaz;
            labNombre.Text = nombre;
            labCodigo.Text = codigo;
            inicializarMapa();
        }

        /* Descripción: Este método inicializa los dos mapas que se visualizan en la interfaz
        */
        private void inicializarMapa()
        {
            mapa.DragButton = MouseButtons.Left;
            mapa.CanDragMap = true;
            mapa.MapProvider = GMapProviders.GoogleMap;
            mapa.MinZoom = 0;
            mapa.MaxZoom = 24;
            mapa.Zoom = 1;
            mapa.AutoScroll = true;
            try
            {
                IPHostEntry e = Dns.GetHostEntry("www.google.com");
            }
            catch
            {
                mapa.Manager.Mode = AccessMode.CacheOnly;
                MessageBox.Show("No se puede cargar el mapa porque no hay conexión a internet",
                      "Aviso", MessageBoxButtons.OK,
                      MessageBoxIcon.Warning);
            }
        }

        private void butRegresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            principal.Visible = true;
        }

        private void InterfazMapa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            principal.Visible = true;
        }
    }
}
