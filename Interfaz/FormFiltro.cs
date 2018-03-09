using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Mundo;
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
using System.Threading;
using System.Diagnostics;

namespace Interfaz
{
    public partial class FormFiltro : Form
    {
        //Atributos
        private FormCargar principal;
        private GMapOverlay marcadoresCiudades;
        private GMapOverlay rutas;
        private List<Ciudad> ciudades;

        public FormFiltro(FormCargar principal)
        {
            InitializeComponent();
            this.principal = principal;
            marcadoresCiudades = new GMapOverlay();
            rutas = new GMapOverlay();
            mapa.Overlays.Add(marcadoresCiudades);
            mapa.Overlays.Add(rutas);
            inicializarMapa();
            gifCargando.Image = Image.FromFile("Img/cargando4.gif");
            ciudades = new List<Ciudad>();

            rbKruskal.Enabled = false;
            rbFuerzaBruta.Enabled = false;
            rbInsercion.Enabled = false;
        }


        private void inicializarMapa()
        {
            mapa.DragButton = MouseButtons.Left;
            mapa.CanDragMap = true;
            mapa.MapProvider = GMapProviders.GoogleMap;
            mapa.AutoScroll = true;
            mapa.MinZoom = 0;
            mapa.MaxZoom = 24;
            mapa.Zoom = 2;
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
        
        private void actualizarTablaCiudadesFiltradas()
        {
            listaCiudades.Items.Clear();
            tablaCiudades.Rows.Clear();
            List<Ciudad> ciudadesV = principal.Aerolinea.Anonimo.darCiudades();
            foreach(Ciudad c in ciudadesV)
            {
                tablaCiudades.Invoke((MethodInvoker)delegate
                {
                    tablaCiudades.Rows.Add(c.Nombre, c.Latitud, c.Longitud, c.Poblacion);
                });
            }
        }

        private void FormFiltro_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Enabled = true;
            this.Dispose();
        }

        private void mapa_MouseDown(object sender, MouseEventArgs e)
        {
            if (!workFiltrar.IsBusy)
            {
                foreach (GMarkerGoogle marcador in marcadoresCiudades.Markers)
                {
                    if (marcador.IsMouseOver)
                    {
                        String nombreCiudad = marcador.ToolTipText;
                        if (rbKruskal.Checked)
                        {
                            DialogResult resultado = MessageBox.Show("¿Quiere generar una ruta aplicando Kruskal-PreOrden desde la ciudad de "+nombreCiudad+"?", "Confirmación", MessageBoxButtons.YesNoCancel);
                            if(resultado == DialogResult.Yes)
                            {
                                labCiudadInicial.Text = nombreCiudad;
                                principal.Aerolinea.acomodarVertices(nombreCiudad);
                                ciudades.Clear();
                                gifCargando.Visible = true;
                                marcadoresCiudades.Markers.Clear();
                                rutas.Markers.Clear();
                                rutas.Routes.Clear();
                                workKruskal.RunWorkerAsync();
                            }
                            break;
                        }
                        else if (rbFuerzaBruta.Checked)
                        {
                            DialogResult resultado = MessageBox.Show("¿Quiere generar una ruta aplicando exploración completa desde la ciudad de " + nombreCiudad + "?", "Confirmación", MessageBoxButtons.YesNoCancel);
                            if(resultado == DialogResult.Yes)
                            {
                                labCiudadInicial.Text = nombreCiudad;
                                principal.Aerolinea.acomodarVertices(nombreCiudad);
                                ciudades.Clear();
                                gifCargando.Visible = true;
                                marcadoresCiudades.Markers.Clear();
                                rutas.Routes.Clear();
                                rutas.Markers.Clear();
                                workFuerzaBruta.RunWorkerAsync();
                            }
                            break;
                        }
                        else if (rbInsercion.Checked)
                        {
                            DialogResult resultado = MessageBox.Show("¿Quiere generar una ruta aplicando inserción desde la ciudad de " + nombreCiudad + "?", "Confirmación", MessageBoxButtons.YesNoCancel);
                            if (resultado == DialogResult.Yes)
                            {
                                labCiudadInicial.Text = nombreCiudad;
                                principal.Aerolinea.acomodarVertices(nombreCiudad);
                                ciudades.Clear();
                                gifCargando.Visible = true;
                                marcadoresCiudades.Markers.Clear();
                                rutas.Routes.Clear();
                                rutas.Markers.Clear();
                                workInsercion.RunWorkerAsync();
                            }
                            break;
                        }

                    }
                }
            }
        }

        private void butFiltrar_Click(object sender, EventArgs e)
        {
            String texto = txtPoblacion.Text;
            if (texto.Equals(""))
            {
                MessageBox.Show("Ingrese una población válida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int numero = 0;
                bool esNumero = int.TryParse(texto, out numero);
                if (esNumero)
                {
                    butFiltrar.Enabled = false;
                    marcadoresCiudades.Markers.Clear();
                    tablaCiudades.Rows.Clear();
                    rutas.Markers.Clear();
                    rutas.Routes.Clear();
                    workFiltrar.WorkerReportsProgress = true;
                    workFiltrar.RunWorkerAsync();
                    listaCiudades.Items.Clear();
                    labCiudadInicial.Text = "";
                }
                else
                {
                    MessageBox.Show("Ingrese una población válida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPoblacion.Text = "";
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void rbKruskal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFuerzaBruta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tablaCiudades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

                if (rbKruskal.Checked)
                {
                    List<Ciudad> c=principal.Aerolinea.solucionCiudadesFiltradas(1);
                    cargarMarcadores(principal.Aerolinea.Anonimo.darCiudades());
                }
                else if (rbFuerzaBruta.Checked)
                {
                    List<Ciudad> c=principal.Aerolinea.solucionCiudadesFiltradas(2);
                    cargarMarcadores(principal.Aerolinea.Anonimo.darCiudades());
                }
                else if (rbInsercion.Checked)
                {
                    List<Ciudad> c=principal.Aerolinea.solucionCiudadesFiltradas(3);
                    cargarMarcadores(principal.Aerolinea.Anonimo.darCiudades());
            }
            
        }
        private void  cargarMarcadores(List<Ciudad> list)
        {
            foreach(Ciudad c in list)
            {
                GMarkerGoogle marque = new GMarkerGoogle(new PointLatLng(c.Latitud, c.Longitud), GMarkerGoogleType.blue_dot);
                marque.ToolTipText = c.Nombre;
                marcadoresCiudades.Markers.Add(marque);
            }
            if (list.Count > 0)
            {
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(list[0].Latitud, list[0].Longitud), GMarkerGoogleType.red_dot);
                marker.ToolTipText = list[0].Nombre;
                marcadoresCiudades.Markers.Add(marker);
            }
        
        }
         
        public void actualizarLista()
        {
            listaCiudades.Items.Clear();
            foreach(Ciudad c in ciudades)
            {
                listaCiudades.Items.Add(c.Nombre);
            }
        }

        public int numeroActual()
        {
            return int.Parse(txtPoblacion.Text);
        }

        private void workFiltrar_DoWork(object sender, DoWorkEventArgs e)
        {
            
            principal.Aerolinea.filtrarCiudades(numeroActual(), workFiltrar, tablaCiudades, label3, marcadoresCiudades);
        }

        private void workFiltrar_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void workFiltrar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Se han encontrado " + principal.Aerolinea.Anonimo.Grafo.Vertices.Count+" ciudades con una población mayor a "+numeroActual());
            rbKruskal.Enabled = true;
            rbFuerzaBruta.Enabled = true;
            rbInsercion.Enabled = true;
            butFiltrar.Enabled = true;
            mapa.Enabled = true;
        }

        private void cargarCiudadesRutas()
        {
            for (int i = 0; i < ciudades.Count; i++)
            {
                Ciudad actual = ciudades[i];
                if (i == ciudades.Count - 1)
                {
                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(actual.Latitud, actual.Longitud), GMarkerGoogleType.red_dot);
                    marker.ToolTipText = actual.Nombre;
                    marcadoresCiudades.Markers.Add(marker);
                }
                else
                {
                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(actual.Latitud, actual.Longitud), GMarkerGoogleType.blue_dot);
                    marker.ToolTipText = actual.Nombre;
                    marcadoresCiudades.Markers.Add(marker);
                }
            }
            for (int i = 0; i < ciudades.Count - 1; i++)
            {
                Ciudad c = ciudades[i];
                Ciudad c1 = ciudades[i + 1];
                List<PointLatLng> puntos = new List<PointLatLng>();
                puntos.Add(new PointLatLng(c.Latitud, c.Longitud));
                puntos.Add(new PointLatLng(c1.Latitud, c1.Longitud));
                int distancia = c.calcularDistancia(c1);
                GMapRoute route = new GMapRoute(puntos, distancia + "");
                route.Stroke.Color = Color.Blue;
                route.Stroke.Width = 1;
                rutas.Markers.Add(new GMarkerCross
                           (new PointLatLng((c.Latitud + c1.Latitud) / 2,
                               (c.Longitud + c1.Longitud) / 2))
                {
                    ToolTipText = distancia + " km",
                    IsVisible = true,
                    ToolTipMode = MarkerTooltipMode.Always
                });
                rutas.Routes.Add(route);
            }
        }
        private void workKruskal_DoWork(object sender, DoWorkEventArgs e)
        {
          
            ciudades = principal.Aerolinea.Anonimo.generarSolucionKruskal();
         
        }

        private void workKruskal_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            gifCargando.Visible = false;
            cargarCiudadesRutas();
            actualizarLista();
        }

        private void workFuerzaBruta_DoWork(object sender, DoWorkEventArgs e)
        {
            ciudades = principal.Aerolinea.Anonimo.generarSolucionFuerzaBruta();

        }

        private void workFuerzaBruta_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            gifCargando.Visible = false;
            cargarCiudadesRutas();
            actualizarLista();
        }

        private void workInsercion_DoWork(object sender, DoWorkEventArgs e)
        {
            ciudades = principal.Aerolinea.Anonimo.generarSolucionInsercion();
        }

        private void workInsercion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            gifCargando.Visible = false;
            cargarCiudadesRutas();
            actualizarLista();
        }
    }
}
