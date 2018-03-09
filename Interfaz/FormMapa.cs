using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Net;
using System.Windows.Forms;
using Mundo;
using System.Collections.Generic;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Drawing;

namespace Interfaz
{
    public partial class FormMapa : Form
    {
        //Atributos
        private FormCargar principal;
        private FormSolucionarTodo principalTodo;
        private GMapOverlay marcadoresViajeros;
        private GMapOverlay rutas;
        private String tipoSolucion;

        //Constructor
        public FormMapa(FormSolucionarTodo principalTodo, String codigo, String tipoSolucion)
        {
            InitializeComponent();
            this.principalTodo = principalTodo;
            principal = principalTodo.Principal;
            this.tipoSolucion = tipoSolucion;
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
            marcadoresViajeros = new GMapOverlay();
            rutas = new GMapOverlay();
            mapa.Overlays.Add(marcadoresViajeros);
            mapa.Overlays.Add(rutas);
            cargarInformacion(codigo, tipoSolucion);
            cbMostrarCiudades.Checked = true;
            cbMostrarRutas.Checked = true;

        }

        public FormMapa(FormCargar principal, String codigo, String tipoSolucion)
        {
            
            InitializeComponent();
            this.principal = principal;
            this.tipoSolucion = tipoSolucion;
            mapa.DragButton = MouseButtons.Left;
            mapa.CanDragMap = true;
            mapa.MapProvider = GMapProviders.GoogleMap;
            mapa.AutoScroll = true;
            mapa.MinZoom = 0;
            mapa.MaxZoom = 24;
            mapa.Zoom = 1;
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
            marcadoresViajeros = new GMapOverlay();
            rutas = new GMapOverlay();
            mapa.Overlays.Add(marcadoresViajeros);
            mapa.Overlays.Add(rutas);
            cargarInformacion(codigo, tipoSolucion);
            cbMostrarCiudades.Checked = true;
            cbMostrarRutas.Checked = true;

        }

        //Métodos
        private void cargarInformacion(String codigo, string tipoSolucion)
        {
            Viajero v;
            if(principalTodo != null)
            {
                if (tipoSolucion.Equals(Viajero.SOLUCION_KRUSKAL_PREORDEN))
                {
                    v = principal.Aerolinea.buscarViajeroKruskal(codigo);
                }
                else if (tipoSolucion.Equals(Viajero.SOLUCION_FUERZA_BRUTA))
                {
                    v = principal.Aerolinea.buscarViajeroFuerzaBruta(codigo);
                }
                else
                {
                    v = principal.Aerolinea.buscarViajeroInsercion(codigo);
                }
            }
            else
            {
                v = principal.Aerolinea.buscarViajero(codigo);
            }
            labCodigo.Text = codigo;
            labNombre.Text = v.Nombre;
            if(v.Grafo.Vertices.Count > 0)
            {
                labCiudadInicio.Text = v.Grafo.Vertices[0].Info.Nombre;

            }

            if (tipoSolucion.Equals(Viajero.SOLUCION_KRUSKAL_PREORDEN))
            {
                List<Ciudad> xd = v.generarSolucionKruskal();
                listaCiudades.Items.Clear();
                cargarMarcadores(xd);
                cargarRutas(xd);
                int i = 1;
                foreach (Ciudad c in xd)
                {
                    listaCiudades.Items.Add(i+". "+c.Nombre);
                    i++;
                }
            }
            else if (tipoSolucion.Equals(Viajero.SOLUCION_FUERZA_BRUTA))
            {
                List<Ciudad> xd = v.generarSolucionFuerzaBruta();
                listaCiudades.Items.Clear();
                cargarMarcadores(xd);
                cargarRutas(xd);
                int i = 1;
                foreach (Ciudad c in xd)
                {
                    listaCiudades.Items.Add(i + ". " + c.Nombre);
                    i++;
                }
            }
            else if (tipoSolucion.Equals(Viajero.SOLUCION_OTRA))
            {
                List<Ciudad> xd = v.generarSolucionInsercion();
                listaCiudades.Items.Clear();
                cargarMarcadores(xd);
                cargarRutas(xd);
                int i = 1;
                foreach (Ciudad c in xd)
                {
                    listaCiudades.Items.Add(i + ". " + c.Nombre);
                    i++;
                }
            }
        }

        private void cargarMarcadores(List<Ciudad> xd)
        {
            String codigo = labCodigo.Text;
            foreach(Ciudad c in xd)
            {
                GMarkerGoogle marque = new GMarkerGoogle(new PointLatLng(c.Latitud, c.Longitud), GMarkerGoogleType.blue_dot);
                marque.ToolTipText = c.Nombre;
                marcadoresViajeros.Markers.Add(marque);
            }
            if(xd.Count > 0)
            {
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(xd[0].Latitud, xd[0].Longitud), GMarkerGoogleType.red_dot);
                marker.ToolTipText = xd[0].Nombre;
                marcadoresViajeros.Markers.Add(marker);
            }
        }

        private void cargarRutas(List<Ciudad> xd)
        {
            if(xd.Count > 0)
            {
                String codigo = labCodigo.Text;
                for (int i = 0; i < xd.Count - 1; i++)
                {
                    Ciudad c = xd[i];
                    Ciudad c1 = xd[i + 1];
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
        }
        private void butRegresar_Click(object sender, EventArgs e)
        {
            if(principalTodo != null)
            {
                principalTodo.Visible = true;
                principalTodo.Enabled = true;
                this.Dispose();
            }
            else
            {
                principal.Visible = true;
                principal.Enabled = true;
                this.Dispose();
            }
        }


        private void inicializarMapas()
        {
            mapa.DragButton = MouseButtons.Left;
            mapa.CanDragMap = true;
            mapa.MapProvider = GMapProviders.GoogleMap;
            mapa.AutoScroll = true;
            mapa.MinZoom = 0;
            mapa.MaxZoom = 24;
            mapa.Zoom = 1;
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

        private void FormMapa_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (principalTodo != null)
            {
                principalTodo.Visible = true;
                principalTodo.Enabled = true;
                this.Dispose();
            }
            else
            {
                principal.Visible = true;
                principal.Enabled = true;
                this.Dispose();
            }
        }

        private void cbMostrarCiudades_CheckedChanged(object sender, EventArgs e)
        {
            if(principalTodo != null)
            {
                if (cbMostrarCiudades.Checked)
                {
                    if (tipoSolucion.Equals(Viajero.SOLUCION_KRUSKAL_PREORDEN))
                    {
                        cargarMarcadores(principal.Aerolinea.buscarViajeroKruskal(labCodigo.Text).generarSolucionKruskal());
                    }
                    else if (tipoSolucion.Equals(Viajero.SOLUCION_FUERZA_BRUTA))
                    {
                        cargarMarcadores(principal.Aerolinea.buscarViajeroFuerzaBruta(labCodigo.Text).generarSolucionFuerzaBruta());
                    }
                    else if (tipoSolucion.Equals(Viajero.SOLUCION_OTRA))
                    {
                        cargarMarcadores(principal.Aerolinea.buscarViajeroInsercion(labCodigo.Text).generarSolucionInsercion());
                    }
                }
                else
                {
                    marcadoresViajeros.Markers.Clear();
                }
            }
            else
            {
                if (cbMostrarCiudades.Checked)
                {
                    if (tipoSolucion.Equals(Viajero.SOLUCION_KRUSKAL_PREORDEN))
                    {
                        cargarMarcadores(principal.Aerolinea.buscarViajero(labCodigo.Text).generarSolucionKruskal());
                    }else if (tipoSolucion.Equals(Viajero.SOLUCION_FUERZA_BRUTA))
                    {
                        cargarMarcadores(principal.Aerolinea.buscarViajero(labCodigo.Text).generarSolucionFuerzaBruta());
                    }else if (tipoSolucion.Equals(Viajero.SOLUCION_KRUSKAL_PREORDEN))
                    {
                        cargarMarcadores(principal.Aerolinea.buscarViajero(labCodigo.Text).generarSolucionInsercion());
                    }
                }
                else
                {
                    marcadoresViajeros.Markers.Clear();
                }
            }
        }

        private void cbMostrarRutas_CheckedChanged(object sender, EventArgs e)
        {
            if(principalTodo != null)
            {
                if (cbMostrarRutas.Checked)
                {
                    if (tipoSolucion.Equals(Viajero.SOLUCION_KRUSKAL_PREORDEN))
                    {
                        cargarRutas(principal.Aerolinea.buscarViajeroKruskal(labCodigo.Text).generarSolucionKruskal());
                    }
                    else if (tipoSolucion.Equals(Viajero.SOLUCION_FUERZA_BRUTA))
                    {
                        cargarRutas(principal.Aerolinea.buscarViajeroFuerzaBruta(labCodigo.Text).generarSolucionFuerzaBruta());
                    }
                    else if (tipoSolucion.Equals(Viajero.SOLUCION_KRUSKAL_PREORDEN))
                    {
                        cargarRutas(principal.Aerolinea.buscarViajeroInsercion(labCodigo.Text).generarSolucionInsercion());
                    }
                }
                else
                {
                    rutas.Markers.Clear();
                    rutas.Routes.Clear();
                }
            }
            else
            {
                if (cbMostrarRutas.Checked)
                {
                    if (tipoSolucion.Equals(Viajero.SOLUCION_KRUSKAL_PREORDEN))
                    {
                        cargarRutas(principal.Aerolinea.buscarViajero(labCodigo.Text).generarSolucionKruskal());
                    }
                    else if (tipoSolucion.Equals(Viajero.SOLUCION_FUERZA_BRUTA))
                    {
                        cargarRutas(principal.Aerolinea.buscarViajero(labCodigo.Text).generarSolucionFuerzaBruta());
                    }
                    else if (tipoSolucion.Equals(Viajero.SOLUCION_KRUSKAL_PREORDEN))
                    {
                        cargarRutas(principal.Aerolinea.buscarViajero(labCodigo.Text).generarSolucionInsercion());
                    }
                }
                else
                {
                    rutas.Markers.Clear();
                    rutas.Routes.Clear();
                }
            }
        }
    }
}
