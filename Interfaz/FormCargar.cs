using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Mundo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FormCargar : Form
    {
        //Atributos
        private Aerolinea aerolinea;
        private FormCiudades formCiudades;
        private FormSolucionViajero formSolucionViajero;
        private FormSolucionarTodo formSolucionarTodo;
        private FormFiltro formFiltro;
        private FormEstadisticas formEstadisticas;
     

        private GMapOverlay marcadoresViajeros;
        private GMapOverlay marcadoresCiudades;

        public Aerolinea Aerolinea
        {
            get
            {
                return aerolinea;
            }

            set
            {
                aerolinea = value;
            }
        }

        //Constructor
        public FormCargar()
        {
            
            InitializeComponent();
            inicializarMapas();
            Aerolinea = new Aerolinea();
            txtBuscarCiudad.Enabled = false;
            butBuscarCiudad.Enabled = false;
            txtBuscarViajero.Enabled = false;
          
            marcadoresCiudades = new GMapOverlay();
            marcadoresViajeros = new GMapOverlay();
            mapaViajeros.Overlays.Add(marcadoresViajeros);
            mapaCiudades.Overlays.Add(marcadoresCiudades);
            butAnterior.Enabled = false;
            butSiguiente.Enabled = false;
            pictureBox1.Image = Image.FromFile("Img/cargando4.gif");
            pictureBox1.Visible = false;
            butSiguiente.Enabled = false;
        }

        private void inicializarMapas()
        {
            mapaCiudades.DragButton = MouseButtons.Left;
            mapaCiudades.CanDragMap = true;
            mapaCiudades.MapProvider = GMapProviders.GoogleMap;
            mapaCiudades.AutoScroll = true;
            mapaCiudades.MinZoom = 0;
            mapaCiudades.MaxZoom = 24;
            mapaCiudades.Zoom = 1;
            mapaViajeros.DragButton = MouseButtons.Left;
            mapaViajeros.CanDragMap = true;
            mapaViajeros.MapProvider = GMapProviders.GoogleMap;
            mapaViajeros.AutoScroll = true;
            mapaViajeros.MinZoom = 0;
            mapaViajeros.MaxZoom = 24;
            mapaViajeros.Zoom = 1;
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

        private void tablaCiudades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(tablaCiudades[0, tablaCiudades.CurrentCell.RowIndex].Value != null)
            {
                //Nombre de la ciudad que se obtiene al presionar el botón Ver de tablaCiudades
                String nombreCiudad = tablaCiudades[0, tablaCiudades.CurrentCell.RowIndex].Value.ToString();
                Ciudad ciudad = Aerolinea.Ciudades[nombreCiudad];
                marcadoresCiudades.Markers.Clear();
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(ciudad.Latitud, ciudad.Longitud), GMarkerGoogleType.blue_dot);
                marker.ToolTipText = ciudad.Nombre;
                marcadoresCiudades.Markers.Add(marker);
            }

        }

        private void tablaViajeros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if(tablaViajeros[0, tablaViajeros.CurrentCell.RowIndex].Value != null)
                {
                //Código del viajero que se obtiene al presionar el LinkLabel de la columna Ciudades de TablaViajeros
                String codigoViajero = tablaViajeros[0, tablaViajeros.CurrentCell.RowIndex].Value.ToString();
                Viajero via = Aerolinea.buscarViajero(codigoViajero);
                formCiudades = new FormCiudades(via.listaCiudadesString());
                formCiudades.Visible = true;
                //Inicializar formCiudades con una List<String> que contenga los nombres de las ciudades (Mirar constructor)
                }

            }

            else if (e.ColumnIndex == 3)
            {
                if (tablaViajeros[0, tablaViajeros.CurrentCell.RowIndex].Value != null)
                {
                    //Código del viajero que se obtiene al presionar el botón Ver de la columna PreView de tablaViajeros
                    String codigoViajero = tablaViajeros[0, tablaViajeros.CurrentCell.RowIndex].Value.ToString();
                    List<Ciudad> cviaje = Aerolinea.buscarViajero(codigoViajero).listaCiudades();
                    marcadoresViajeros.Markers.Clear();
                    foreach(Ciudad ciudad in cviaje)
                    {
                        GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(ciudad.Latitud, ciudad.Longitud), GMarkerGoogleType.blue_dot);
                        marker.ToolTipText = ciudad.Nombre;
                        marcadoresViajeros.Markers.Add(marker);
                    }
                }
            }
            else if (e.ColumnIndex == 4)
            {
                if(tablaViajeros[0, tablaViajeros.CurrentCell.RowIndex].Value != null)
                {
                    //Código del viajero que se obtiene al presionar el botón Ver de la columna MapView de tablaViajeros
                    String codigoViajero = tablaViajeros[0, tablaViajeros.CurrentCell.RowIndex].Value.ToString();
                    
                    //Inicializar formSolucionViajero con el codigo del viajero
                    formSolucionViajero = new FormSolucionViajero(this, codigoViajero);
                    formSolucionViajero.Visible = true;
                    this.Enabled = false;
                }
            }
        }

        private String cargarArchivo()
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            String ruta = file.FileName.ToString();
            file.Multiselect = false;
            if (ruta.Equals(""))
            {
                throw new Exception("No se seleccionó ningún archivo");
            }
            if (!ruta.Equals("") && !ruta.EndsWith("txt"))
            {
                throw new Exception("No se puede cargar el archivo (Formato de archivo inválido)");
            }
            return ruta;
        }

        private void butCargarCiudades_Click(object sender, EventArgs e)
        {
            try
            {
                String ruta = cargarArchivo();
                Aerolinea.cargarCiudades(ruta);
                workCargarCiudades.WorkerReportsProgress = true;
                tablaCiudades.Rows.Clear();
                workCargarCiudades.RunWorkerAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void butCargarViajeros_Click(object sender, EventArgs e)
        {
           try
           {
            String ruta = cargarArchivo();
            Aerolinea.RutaViajeros= ruta;
            Aerolinea.cargarViajeros(ruta, 0);
           
            //MessageBox.Show(aerolinea.Viajeros.Count() + "");
            workContarPaginas.RunWorkerAsync();
            workCargarViajeros.WorkerReportsProgress = true;
    

            tablaViajeros.Rows.Clear();
            workCargarViajeros.RunWorkerAsync();
           }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void recargarViajeros(int npagina)
        {
            string ruta = Aerolinea.RutaViajeros;
            if(Aerolinea.Paginas[npagina] != null)
            {
                Aerolinea.cargarViajeros(ruta, Aerolinea.Paginas[npagina].Nlineainicio);
                actualizarTablaViajeros2();
                labPagina.Text = Aerolinea.PaginaActual+"";
            }
        }
        private void recargarViajerosIr(int npagina)
        {
            string ruta = Aerolinea.RutaViajeros;
            Aerolinea.cargarViajeros(ruta, Aerolinea.Paginas[npagina].Nlineainicio);
            actualizarTablaViajeroIr();
            labPagina.Text = Aerolinea.PaginaActual + "";
        }



        private void actualizarTablaViajeros2()
        {
            tablaViajeros.Rows.Clear();
            List<Viajero> xd = Aerolinea.Viajeros;
            foreach(Viajero v in xd)
            {
                tablaViajeros.Rows.Add(v.Codigo, v.Nombre);
            }
        }

        private void actualizarTablaViajeroIr()
        {
            tablaViajeros.Invoke((MethodInvoker)delegate {
                tablaViajeros.Rows.Clear();
                List<Viajero> xd = Aerolinea.Viajeros;
                foreach (Viajero v in xd)
                {
                    tablaViajeros.Rows.Add(v.Codigo, v.Nombre);
                }
            });
        }
        private void actualizarTablaCiudades()
        {
            Dictionary<String, Ciudad> cids = Aerolinea.Ciudades;
            Ciudad[] ciudades = cids.Values.ToArray<Ciudad>();
            for(int i = 0; i < ciudades.Length; i++)
            {
                Ciudad var = ciudades[i];
                tablaCiudades.Invoke((MethodInvoker)delegate
                {
                    tablaCiudades.Rows.Add(var.Nombre, var.Latitud, var.Longitud, var.Poblacion);

                });
                int progress = 1+(i * 100) / ciudades.Length;
                labPorcentajeCiudades.Invoke((MethodInvoker)delegate
                {
                    labPorcentajeCiudades.Text = progress+"%";
                });
                workCargarCiudades.ReportProgress(progress);
            }
        }

        private void actualizarTablaViajeros()
        {
            List<Viajero> xd = Aerolinea.Viajeros;
            for (int i = 0; i <xd.Count; i++)
            {
                Viajero v = xd[i];
                tablaViajeros.Invoke((MethodInvoker)delegate
                {
                    tablaViajeros.Rows.Add(v.Codigo,v.Nombre);

                });

                int progress = 1 + (i * 100) / xd.Count;
                workCargarViajeros.ReportProgress(progress);
            }
        }

        private void txtBuscarViajero_TextChanged(object sender, EventArgs e)
        {
            string var=txtBuscarViajero.Text;
            List<Viajero> viaj = Aerolinea.listaViajerosFiltrados(var);
            tablaViajeros.Rows.Clear();
            foreach(Viajero v in viaj)
            {
                tablaViajeros.Rows.Add(v.Codigo, v.Nombre);
            }
                
        }

        private void butSolucionarTodo_Click(object sender, EventArgs e)
        {
            formSolucionarTodo = new FormSolucionarTodo(this);
            formSolucionarTodo.Visible = true;
            this.Visible = false;
        }

        private void workCargarCiudades_DoWork(object sender, DoWorkEventArgs e)
        {
            actualizarTablaCiudades();
        }

        private void workCargarCiudades_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            barraCiudades.Value = e.ProgressPercentage;
        }

        private void workCargarCiudades_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            txtBuscarCiudad.Enabled = true;
            panel3.Enabled = true;
            butBuscarCiudad.Enabled = true;
            tablaCiudades.Enabled = true;
            butFiltro.Enabled = true;
        }

        public void filtrarBusqueda()
        {
            string var = txtBuscarCiudad.Text;
            List<Ciudad> ciu = Aerolinea.listaCiudadesFiltradas(var);
            tablaCiudades.Rows.Clear();
            foreach(Ciudad c in ciu)
            {
                tablaCiudades.Invoke((MethodInvoker)delegate
                {
                    tablaCiudades.Rows.Add(c.Nombre,c.Latitud,c.Longitud,c.Poblacion);

                });
            }
        }

        public DataGridView TablaCiudades
        {
            get { return tablaCiudades; }
            set { tablaCiudades = value; }
        }

        private void workFiltrarCiudades_DoWork(object sender, DoWorkEventArgs e)
        {
            filtrarBusqueda();
        }

        private void butBuscarCiudad_Click(object sender, EventArgs e)
        {
            workFiltrarCiudades.RunWorkerAsync();
            tablaCiudades.Rows.Clear();
            butBuscarCiudad.Enabled = false;
        }

        private void workFiltrarCiudades_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            butBuscarCiudad.Enabled = true;
        }

        private void workCargarViajeros_DoWork(object sender, DoWorkEventArgs e)
        {
            actualizarTablaViajeros();
        }

        private void workCargarViajeros_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           // barraViajeros.Value = e.ProgressPercentage;
        }

        private void workCargarViajeros_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            txtBuscarViajero.Enabled = true;
        
        }

        private void txtBuscarCiudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void butSiguiente_Click(object sender, EventArgs e)
        {
            if (Aerolinea.PaginaActual == Aerolinea.PaginasTotales-1)
            {
                butSiguiente.Enabled = false;
                Aerolinea.PaginaActual++;
                labPagina.Text = Aerolinea.PaginaActual + "";
                recargarViajeros(Aerolinea.PaginaActual);
                butAnterior.Enabled = true;
            }
            else
            {
                Aerolinea.PaginaActual++;
                labPagina.Text = Aerolinea.PaginaActual + "";
                recargarViajeros(Aerolinea.PaginaActual);
                butAnterior.Enabled = true;

            }
          
            
        }

        private void butAnterior_Click(object sender, EventArgs e)
        {
            if (Aerolinea.PaginaActual == 2)
            {
                butAnterior.Enabled = false;
                Aerolinea.PaginaActual--;
                labPagina.Text = Aerolinea.PaginaActual + "";
                recargarViajeros(Aerolinea.PaginaActual);
                butSiguiente.Enabled = true;
            }
            else
            {
                Aerolinea.PaginaActual--;
                labPagina.Text = Aerolinea.PaginaActual + "";
                recargarViajeros(Aerolinea.PaginaActual);
                butSiguiente.Enabled = true;
            }
        }

        

        private void butBuscarTodo_Click(object sender, EventArgs e)
        {

            if (!txtBuscarViajero.Text.Equals(""))
            {
                tablaViajeros.Enabled = false;
                txtBuscarViajero.Enabled = false;
              
                pictureBox1.Visible = true;
                butBuscarTodo.Enabled = false;
                mapaViajeros.Visible = false;
                workBuscarViajero.RunWorkerAsync();

            }



        }

        private void workBuscarViajero_DoWork(object sender, DoWorkEventArgs e)
        {
            string nviajero = txtBuscarViajero.Text;
            Viajero v = Aerolinea.buscarViajeroEnTexto(nviajero);
            if (v != null)
            {
                tablaViajeros.Invoke((MethodInvoker)delegate
                {
                    tablaViajeros.Rows.Clear();
                    tablaViajeros.Rows.Add(v.Codigo, v.Nombre);

                });
               
            }
        }

        private void workBuscarViajero_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Visible = false;
            
            txtBuscarViajero.Enabled = true;
            tablaViajeros.Enabled = true;
            mapaViajeros.Visible = true;
            butBuscarTodo.Enabled = true;
        }

        private void workContarPaginas_DoWork(object sender, DoWorkEventArgs e)
        {
            butIr.Invoke((MethodInvoker)delegate {
                butIr.Enabled = false;
            });
            txtBuscarPagina.Invoke((MethodInvoker)delegate {
                txtBuscarPagina.Enabled = false;
            });
            Aerolinea.contarPaginasBytes();

        }

        private void workContarPaginas_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            butSolucionarTodo.Enabled = true;
            labPaginasTotales.Invoke((MethodInvoker)delegate
            {
                labPaginasTotales.Text = "(" + Aerolinea.PaginasTotales + " Páginas)";
            });

            butSiguiente.Invoke((MethodInvoker)delegate {
                butSiguiente.Enabled = true;
            });
            butIr.Invoke((MethodInvoker)delegate {
                butIr.Enabled = true;
            });
            txtBuscarPagina.Invoke((MethodInvoker)delegate {
                txtBuscarPagina.Enabled = true;
            });

          

        }

        private void butIr_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            workIr.RunWorkerAsync();
            mapaViajeros.Visible = false;
        }

        private void workIr_DoWork(object sender, DoWorkEventArgs e)
        {
            string texto = txtBuscarPagina.Text;
            if (!texto.Equals(""))
            {
                int num = 0;
                if (int.TryParse(texto, out num))
                {
                    if (num <= Aerolinea.PaginasTotales)
                    {

                        recargarViajerosIr(num);
                        Aerolinea.PaginaActual = num;
                        
                        labPagina.Invoke((MethodInvoker)delegate {
                            labPagina.Text = num + "";
                        });

                        

                    }
                    else
                    {
                        MessageBox.Show("Número de´página fuera del rango", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un valor numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void workIr_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Visible = false;
            mapaViajeros.Visible = true;
            if (Aerolinea.PaginaActual == Aerolinea.PaginasTotales)
            {
                butAnterior.Invoke((MethodInvoker)delegate {
                    butAnterior.Enabled = true;

                });
                butSiguiente.Invoke((MethodInvoker)delegate {
                    butSiguiente.Enabled = false;

                });


            }
            else if(Aerolinea.PaginaActual==1)
            {
                butAnterior.Invoke((MethodInvoker)delegate {
                    butAnterior.Enabled = false;
                   
                });
                butSiguiente.Invoke((MethodInvoker)delegate {
                    butSiguiente.Enabled = true;

                });


            }else
            {
                butAnterior.Invoke((MethodInvoker)delegate {
                    butAnterior.Enabled = true;

                });
                butSiguiente.Invoke((MethodInvoker)delegate {
                    butSiguiente.Enabled = true;

                });
            }
        }

        private void butSolucionarTodo_Click_1(object sender, EventArgs e)
        {
            formSolucionarTodo = new FormSolucionarTodo(this);
            formSolucionarTodo.Visible = true;
            this.Enabled = false;
        }

        private void butFiltro_Click(object sender, EventArgs e)
        {
            formFiltro = new FormFiltro(this);
            formFiltro.Visible = true;
            this.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formEstadisticas = new FormEstadisticas(this);
            formEstadisticas.Visible = true;
        }
    }
}
