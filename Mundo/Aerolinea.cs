using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mundo
{
    public class Aerolinea
    {

        //Atributos

        private Viajero viajeroAnonimo;
        private List<Viajero> viajeros;
        private List<Viajero> viajerosSolucionKruskal;
        private List<Viajero> viajerosSolucionFuerzaBruta;
        private List<Viajero> viajerosSolucionInsercion;
        private Dictionary<string, Ciudad> ciudades;
        private String rutaCiudades;
        private String rutaViajeros;
        private int lineaActual;
        private int paginaActual;
        private int paginasTotales;
        private List<Pagina> paginas;

        public const String NOMBRE_DEFAULT = "Anonimo";
        public const String CODIGO_DEFAULT = "000";
        

        //Constructor
        public Aerolinea()
        {
            paginaActual = 1;
            viajeros = new List<Viajero>();
            viajerosSolucionKruskal = new List<Viajero>();
            viajerosSolucionFuerzaBruta = new List<Viajero>();
            viajerosSolucionInsercion = new List<Viajero>();
            ciudades = new Dictionary<string, Ciudad>();
            lineaActual = 0;
            viajeroAnonimo = new Viajero(CODIGO_DEFAULT,NOMBRE_DEFAULT);
            //cargarParginas(PaginasTotales);
        }

        //Métodos

        public Viajero Anonimo
        {
            get
            {
                return viajeroAnonimo;
            }
            set
            {
                viajeroAnonimo = value;
            }
        }
        public List<Ciudad> CiudadesNoFiltradas
        {
            get
            {
                return CiudadesNoFiltradas;
            }
            set
            {
                CiudadesNoFiltradas = value;
            }
        }
        public List<Viajero> Viajeros
        {
            get
            {
                return viajeros;
            }

            set
            {
                viajeros = value;
            }
        }

        public Dictionary<string, Ciudad> Ciudades
        {
            get
            {
                return ciudades;
            }

            set
            {
                ciudades = value;
            }
        }

        
        public List<Pagina> Paginas
        {
            get
            {
                return paginas;
            }

            set
            {
                paginas = value;
            }
        }

        public string RutaCiudades
        {
            get
            {
                return rutaCiudades;
            }

            set
            {
                rutaCiudades = value;
            }
        }

        public string RutaViajeros
        {
            get
            {
                return rutaViajeros;
            }

            set
            {
                rutaViajeros = value;
            }
        }

        public int PaginaActual
        {
            get
            {
                return paginaActual;
            }

            set
            {
                paginaActual = value;
            }
        }

        public int PaginasTotales
        {
            get
            {
                return paginasTotales;
            }

            set
            {
                paginasTotales = value;
            }
        }

        public void cargarParginas(int npaginas)
        {
            Paginas = new List<Pagina>();
            Pagina p1 = new Pagina(0, 0);
            Paginas.Add(p1);
            int n = 0;
            for (int i = 1; i<= npaginas; i++)
            {
                Pagina pag = new Pagina(i, n);
                n += Viajero.NUMERO_A_CARGAR;
                Paginas.Add(pag);
            }

        }
        public void cargarCiudades(String ruta)
        {
            RutaCiudades = ruta;
            string line;
            StreamReader file = new StreamReader(RutaCiudades);
            while ((line = file.ReadLine()) != null)
                {
                string[] datos = line.Split(new char[] { ',' });
                if (!estaCiudad(datos[1]))
                {
                    if (datos.Length == 7) { 
                    Ciudad c = new Ciudad(datos[1], Double.Parse(datos[5].Replace('.',',')), Double.Parse(datos[6].Replace('.', ',')),Int32.Parse(datos[4]));
                    ciudades.Add(c.Nombre, c);
                    viajeroAnonimo.agregarCiudad(c);
                    }
                }
            }
        }

        public Viajero buscarViajeroFuerzaBruta(string codigo)
        {
            foreach (Viajero v in viajerosSolucionFuerzaBruta)
            {
                if (v.Codigo.Equals(codigo))
                {
                    return v;
                }
            }
            return null;
        }

        public Viajero buscarViajeroInsercion(string codigo)
        {
            foreach (Viajero v in viajerosSolucionInsercion)
            {
                if (v.Codigo.Equals(codigo))
                {
                    return v;
                }
            }
            return null;
        }

        public List<Viajero> listaViajerosFiltrados(string nombreViaj)
        {
           List<Viajero> viajeros = new List<Viajero>();
           string nom = nombreViaj.ToLower();
           foreach(Viajero v in Viajeros)
            {
                string nomv = v.Nombre.ToLower();
            
                if (nomv.StartsWith(nom))
                {
                    viajeros.Add(v);
                }
            }
            return viajeros;
        }

        public Viajero buscarViajeroEnTexto(string nombre)
        {
            string line;
            StreamReader file = new StreamReader(RutaViajeros);
            while ((line = file.ReadLine()) != null)
            {
                string[] datos = line.Split('\t');
                if ((datos[2]+" "+datos[1]).ToLower().Equals(nombre.ToLower()))
                {

                    
                    Viajero v = new Viajero(datos[0], datos[2] + " " + datos[1]);
                    string[] ciudades = datos[3].Split(',');
                    for (int j = 0; j < ciudades.Length; j++)
                    {
                        Ciudad c = buscarCiudad(ciudades[j].Split('_')[1]);

                        if (c != null)
                        {

                            v.agregarCiudad(c);
                        }
                    }
                    if (buscarViajero(v.Nombre) == null)
                    {

                    agregarViajero(v);
                    }
                    return v;
              
                }
             
            }
            return null;

        }
        public void cargarViajeros(String ruta, int nlinea)
        {
            viajeros.Clear();
            int nlin = 0;
            int nfin = nlinea + Viajero.NUMERO_A_CARGAR;
            RutaViajeros = ruta;
            string line;
            StreamReader file = new StreamReader(RutaViajeros);
            while ((line = file.ReadLine()) != null)
            {
                if (nlin == nlinea)
                {
                    for(int i = nlin; i < nfin && line!=null; i++)
                    {
                        string[] datos = line.Split('\t');
                        Viajero v = new Viajero(datos[0], datos[2] + " " + datos[1]);
                        string[] ciudades = datos[3].Split(',');
                        for (int j = 0; j < ciudades.Length; j++)
                        {
                            Ciudad c = buscarCiudad(ciudades[j].Split('_')[1]);

                            if (c != null)
                            {

                            v.agregarCiudad(c);
                            }
                        }
                        if (v.Grafo.Vertices.Count > 0)
                        {
                            agregarViajero(v);
                        }
                        line = file.ReadLine();
                    }
                    break;
                }
                else
                {
                    nlin++;
                    continue;
                }
            }
        }


        public List<Viajero> cargarViajerosKruskal(DataGridView tabla, ProgressBar barra, Label etiqueta, String ruta, int nlinea)
        {
            int nlin = 0;
            int nfin = nlinea + paginas[paginas.Count-1].NlineaFinal;
            RutaViajeros = ruta;
            string line;
            StreamReader file = new StreamReader(RutaViajeros);
            while ((line = file.ReadLine()) != null)
            {
                if (nlin == nlinea)
                {
                    for (int i = nlin; i < nfin && line != null; i++)
                    {
                        string[] datos = line.Split('\t');
                        Viajero v = new Viajero(datos[0], datos[2] + " " + datos[1]);
                        string[] ciudades = datos[3].Split(',');
                        for (int j = 0; j < ciudades.Length; j++)
                        {
                            Ciudad c = buscarCiudad(ciudades[j].Split('_')[1]);

                            if (c != null)
                            {

                                v.agregarCiudad(c);
                            }
                        }
                        if (v.Grafo.Vertices.Count > 0)
                        {
                            viajerosSolucionKruskal.Add(v);
                        }
                        tabla.Invoke((MethodInvoker)delegate
                        {
                            tabla.Rows.Add(v.Codigo, v.Nombre);
                            tabla.Rows[tabla.Rows.Count - 1].Selected = true;
                            tabla.CurrentCell = tabla.Rows[tabla.Rows.Count - 1].Cells[0];
                        });
                        int porcentaje = (i * 100) / nfin;
                        barra.Invoke((MethodInvoker)delegate
                        {
                            barra.Value = porcentaje;
                        });
                        etiqueta.Invoke((MethodInvoker)delegate
                        {
                            etiqueta.Text = porcentaje + "%";
                        });
                        line = file.ReadLine();
                    }
                    break;
                }
                else
                {
                    nlin++;
                    continue;
                }
            }
            return viajerosSolucionKruskal;
        }

        public List<Viajero> cargarViajerosFuerzaBruta(DataGridView tabla, ProgressBar barra, Label etiqueta, String ruta, int nlinea)
        {
            int nlin = 0;
            int nfin = nlinea + paginas[paginas.Count - 1].NlineaFinal;
            RutaViajeros = ruta;
            string line;
            StreamReader file = new StreamReader(RutaViajeros);
            while ((line = file.ReadLine()) != null)
            {
                if (nlin == nlinea)
                {
                    for (int i = nlin; i < nfin && line != null; i++)
                    {
                        string[] datos = line.Split('\t');
                        Viajero v = new Viajero(datos[0], datos[2] + " " + datos[1]);
                        string[] ciudades = datos[3].Split(',');
                        for (int j = 0; j < ciudades.Length; j++)
                        {
                            Ciudad c = buscarCiudad(ciudades[j].Split('_')[1]);

                            if (c != null)
                            {

                                v.agregarCiudad(c);
                            }
                        }
                        if (v.Grafo.Vertices.Count > 0)
                        {
                            viajerosSolucionFuerzaBruta.Add(v);
                            v.generarSolucionFuerzaBruta();
                        }
                        tabla.Invoke((MethodInvoker)delegate
                        {
                            tabla.Rows.Add(v.Codigo, v.Nombre);
                            tabla.Rows[tabla.Rows.Count - 1].Selected = true;
                            tabla.CurrentCell = tabla.Rows[tabla.Rows.Count - 1].Cells[0];
                        });
                        int porcentaje = (i * 100) / nfin;
                        barra.Invoke((MethodInvoker)delegate
                        {
                            barra.Value = porcentaje;
                        });
                        etiqueta.Invoke((MethodInvoker)delegate
                        {
                            etiqueta.Text = porcentaje + "%";
                        });
                        line = file.ReadLine();
                    }
                    break;
                }
                else
                {
                    nlin++;
                    continue;
                }
            }
            return viajerosSolucionFuerzaBruta;
        }

        public List<Viajero> cargarViajerosInsercion(DataGridView tabla, ProgressBar barra, Label etiqueta, String ruta, int nlinea)
        {
            int nlin = 0;
            int nfin = nlinea + paginas[paginas.Count - 1].NlineaFinal;
            RutaViajeros = ruta;
            string line;
            StreamReader file = new StreamReader(RutaViajeros);
            while ((line = file.ReadLine()) != null)
            {
                if (nlin == nlinea)
                {
                    for (int i = nlin; i < nfin && line != null; i++)
                    {
                        string[] datos = line.Split('\t');
                        Viajero v = new Viajero(datos[0], datos[2] + " " + datos[1]);
                        string[] ciudades = datos[3].Split(',');
                        for (int j = 0; j < ciudades.Length; j++)
                        {
                            Ciudad c = buscarCiudad(ciudades[j].Split('_')[1]);

                            if (c != null)
                            {

                                v.agregarCiudad(c);
                            }
                        }
                        if (v.Grafo.Vertices.Count > 0)
                        {
                            viajerosSolucionInsercion.Add(v);
                            v.generarSolucionInsercion();
                        }
                        tabla.Invoke((MethodInvoker)delegate
                        {
                            tabla.Rows.Add(v.Codigo, v.Nombre);
                            tabla.Rows[tabla.Rows.Count - 1].Selected = true;
                            tabla.CurrentCell = tabla.Rows[tabla.Rows.Count - 1].Cells[0];
                        });
                        int porcentaje = (i * 100) / nfin;
                        barra.Invoke((MethodInvoker)delegate
                        {
                            barra.Value = porcentaje;
                        });
                        etiqueta.Invoke((MethodInvoker)delegate
                        {
                            etiqueta.Text = porcentaje + "%";
                        });
                        line = file.ReadLine();
                    }
                    break;
                }
                else
                {
                    nlin++;
                    continue;
                }
            }
            return viajerosSolucionFuerzaBruta;
        }

        public void agregarViajero(Viajero v)
        {
            viajeros.Add(v);
        }

        public bool estaCiudad(string nciudad)
        {
            return ciudades.ContainsKey(nciudad);
        }

        public Ciudad buscarCiudad(string nciudad)
        {
            if (estaCiudad(nciudad))
            {
                return ciudades[nciudad];
            }
            else
            {
                return null;
            }
        }

        public List<Ciudad> listaCiudadesFiltradas(String nombreCiudad)
        {
            List<Ciudad> ciuds = new List<Ciudad>();
            foreach (KeyValuePair<String, Ciudad> var in ciudades)
            {
                if (var.Key.ToLower().StartsWith(nombreCiudad.ToLower()))
                {
                    ciuds.Add(var.Value);
                }
            }
            return ciuds;
        }

        public Viajero buscarViajero(string codigo)
        {
            foreach(Viajero v in viajeros)
            {
                if (v.Codigo.Equals(codigo))
                {
                    return v;
                }
            }
            return null;
        }

        public Viajero buscarViajeroKruskal(string codigo)
        {
            foreach (Viajero v in viajerosSolucionKruskal)
            {
                if (v.Codigo.Equals(codigo))
                {
                    return v;
                }
            }
            return null;
        }

        public void contarPaginasStream()
        {

            long lineCount = 0;
            var sw = Stopwatch.StartNew();
            StreamReader file = new StreamReader(rutaViajeros);
            while (file.ReadLine() != null) { lineCount++; }
            Console.WriteLine("[StreamReader] - Read: {0:n} in {1}", lineCount, sw.Elapsed);

            PaginasTotales = Int32.Parse(Math.Ceiling((Decimal)lineCount / Viajero.NUMERO_A_CARGAR)+"");
            cargarParginas(PaginasTotales);
            }

        public void contarPaginasStreamLinQ()
        {
            var sw = Stopwatch.StartNew();
            var lineCount = File.ReadLines(rutaViajeros).Count();
            Console.WriteLine("[FileStream] - Read: {0:n} in {1}", lineCount, sw.Elapsed);

            PaginasTotales = Int32.Parse(Math.Ceiling((Decimal)lineCount / Viajero.NUMERO_A_CARGAR) + "");
            cargarParginas(PaginasTotales);
        }

        public void contarPaginasBytes()
        {
            var sw = Stopwatch.StartNew();
            using (var fs = new FileStream(rutaViajeros, FileMode.Open, FileAccess.Read))
            {
                long lineCount = 0;
                byte[] buffer = new byte[1024 * 1024];
                int bytesRead;

                do
                {
                    bytesRead = fs.Read(buffer, 0, buffer.Length);
                    for (int i = 0; i < bytesRead; i++)
                        if (buffer[i] == '\n')
                            lineCount++;
                }
                while (bytesRead > 0);
                Console.WriteLine("[FileStream] - Read: {0:n} in {1}", lineCount, sw.Elapsed);
                PaginasTotales = Int32.Parse(Math.Ceiling((Decimal)lineCount / Viajero.NUMERO_A_CARGAR) + "");
                cargarParginas(PaginasTotales);
            }
        }

        public void refrescarSolucionTotalKruskal(DataGridView tabla, ProgressBar barra, Label etiqueta, int indice)
        {
            Pagina pagina = paginas[indice];
            List<Viajero> viajerosTemp = cargarViajerosKruskal(tabla, barra, etiqueta, rutaViajeros, 0);
        }

        public void refrescarSolucionTotalFuerzaBruta(DataGridView tabla, ProgressBar barra, Label etiqueta, int indice)
        {
            Pagina pagina = paginas[indice];
            List<Viajero> viajerosTemp = cargarViajerosFuerzaBruta(tabla, barra, etiqueta, rutaViajeros, 0);
        }

        public void refrescarSolucionTotalInsercion(DataGridView tabla, ProgressBar barra, Label etiqueta, int indice)
        {
            Pagina pagina = paginas[indice];
            List<Viajero> viajerosTemp = cargarViajerosInsercion(tabla, barra, etiqueta, rutaViajeros, 0);
        }

        public void filtrarCiudades(int poblacion, BackgroundWorker bw, DataGridView tabla, Label lab, GMapOverlay overlay)
        {
            viajeroAnonimo.Grafo.Vertices.Clear();
            for(int i = 0; i < ciudades.Values.Count; i++)
            {
                Ciudad actual = ciudades.Values.ElementAt(i);
                if(actual.Poblacion >= poblacion)
                {
                    viajeroAnonimo.agregarCiudad(actual);
                    tabla.Invoke((MethodInvoker)delegate
                    {
                        tabla.Rows.Add(actual.Nombre, actual.Latitud, actual.Longitud, actual.Poblacion);
                    });
                    GMarkerGoogle marker = new GMarkerGoogle(new GMap.NET.PointLatLng(actual.Latitud, actual.Longitud), GMarkerGoogleType.blue_dot);
                    marker.ToolTipText = actual.Nombre;
                    overlay.Markers.Add(marker);
                }
                int division = ((i * 100) / ciudades.Values.Count) + 1;
                lab.Invoke((MethodInvoker)delegate
                {
                    lab.Text = division + "%";
                });

                bw.ReportProgress(division);
            }
        }

        // el parametro es la forma en que lo va a solucionar, 1 es por el arbol de expansión mínima, 2 es por fuerza bruta y 3 es por otra solución.
        public List<Ciudad> solucionCiudadesFiltradas(int i)
        {
            if (i == 1)
            {
                return viajeroAnonimo.generarSolucionKruskal();
            }else if (i == 2)
            {
                return viajeroAnonimo.generarSolucionFuerzaBruta();
            }
            else 
            {
                return viajeroAnonimo.generarSolucionInsercion();
            }
        }

        public void acomodarVertices(String ciudadInicial)
        {
            Anonimo.CiudadesSolucionFuerzaBruta.Clear();
            Anonimo.DistanciaFuerzaBruta = int.MaxValue;
            Ciudad inicial = ciudades[ciudadInicial];
            List<Ciudad> nuevasCiudades = new List<Ciudad>();
            nuevasCiudades.Add(inicial);
            for(int i = 0; i < Anonimo.Grafo.Vertices.Count; i++)
            {
                Ciudad cVertice = Anonimo.Grafo.Vertices[i].Info;
                if(!cVertice.Nombre.Equals(inicial.Nombre))
                {
                    nuevasCiudades.Add(cVertice);
                }
            }
            Anonimo.Grafo.Vertices.Clear();
            foreach(Ciudad c in nuevasCiudades)
            {
                Anonimo.agregarCiudad(c);
            }
        }
    }
}
