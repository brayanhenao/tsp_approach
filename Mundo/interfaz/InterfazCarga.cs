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
    public partial class InterfazCarga : Form
    {
        //Atributos
        private InterfazOpcionesViajero interfazOpcionesViajero;
        private InterfazSolucion interfazSolucion;
        private InterfazMapa interfazMapa;

        //Constructor
        public InterfazCarga()
        {
            InitializeComponent();
            inicializarMapas();
        }

        /* Descripción: Este método inicializa los dos mapas que se visualizan en la interfaz
        */
        private void inicializarMapas()
        {
            mapaCiudades.DragButton = MouseButtons.Left;
            mapaCiudades.CanDragMap = true;
            mapaCiudades.MapProvider = GMapProviders.GoogleMap;
            mapaCiudades.MinZoom = 0;
            mapaCiudades.MaxZoom = 24;
            mapaCiudades.Zoom = 1;
            mapaCiudades.AutoScroll = true;

            mapaViajeros.DragButton = MouseButtons.Left;
            mapaViajeros.CanDragMap = true;
            mapaViajeros.MapProvider = GMapProviders.GoogleMap;
            mapaViajeros.MinZoom = 0;
            mapaViajeros.MaxZoom = 24;
            mapaViajeros.Zoom = 1;
            mapaViajeros.AutoScroll = true;
            try
            {
                IPHostEntry e = Dns.GetHostEntry("www.google.com");
            }
            catch
            {
                mapaCiudades.Manager.Mode = AccessMode.CacheOnly;
                mapaViajeros.Manager.Mode = AccessMode.CacheOnly;
                MessageBox.Show("No se puede cargar el mapa porque no hay conexión a internet",
                      "Aviso", MessageBoxButtons.OK,
                      MessageBoxIcon.Warning);
            }
        }

        /* Descripción: Este método muestra un cuadro de diálogo que permite seleccionar archivos de texto y retornar la
        *  ruta su origen
        *  @return: String con la ruta del archivo si tiene extensión .txt, Null si no se selecciona nada o el archivo no
        *  tiene extensión .txt
        */
        private String seleccionarArchivo()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            DialogResult resultado = openFileDialog.ShowDialog();
            String ruta = openFileDialog.FileName;
            if(ruta.EndsWith("txt"))
            {
                return ruta;

            }
            return null;
        }

        /* Descripción: Evento generado al presionar el botón butCargarCiudades
        */
        private void butCargarCiudades_Click(object sender, EventArgs e)
        {
            String ruta = seleccionarArchivo();
            if(ruta != null)
            {
                //Llamar método de carga
            }
            else
            {
                MessageBox.Show("Formato de archivo inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /* Descripción: Evento generado al presionar el botón butCargarViajeros
        */
        private void butCargarViajeros_Click(object sender, EventArgs e)
        {
            String ruta = seleccionarArchivo();
            if (ruta != null)
            {
                //Llamar método de carga
            }
            else
            {
                MessageBox.Show("Formato de archivo inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /* Descripción: Evento generado al presionar el botón butSoluciones
        */
        private void butSoluciones_Click(object sender, EventArgs e)
        {
            interfazSolucion = new InterfazSolucion(this);
            this.Enabled = false;
            interfazSolucion.Visible = true;
        }
    }
}