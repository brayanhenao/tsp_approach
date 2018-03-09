using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Mundo
{
    public class Viajero
    {
        //Atributos
        private string nombre;
        private string codigo;

        private int distanciaFuerzaBruta;
        private List<Ciudad> ciudadesSolucionFuerzaBruta;
        private List<Ciudad> ciudadesSolucionInsercion;
        private Grafo<Ciudad> grafo;

        public const String SOLUCION_KRUSKAL_PREORDEN ="kruskal";
        public const String SOLUCION_FUERZA_BRUTA = "fuerza bruta";
        public const String SOLUCION_OTRA = "otra";
        public const int NUMERO_A_CARGAR = 500;

        //Constructor
        public Viajero(string codigo, string nombre)
        {
            this.Nombre = nombre;
            this.Codigo = codigo;
            DistanciaFuerzaBruta = Int32.MaxValue;
            CiudadesSolucionFuerzaBruta = new List<Ciudad>();
            ciudadesSolucionInsercion = new List<Ciudad>();

            grafo = new Grafo<Ciudad>();
        }

        //Métodos
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public Grafo<Ciudad> Grafo
        {
            get
            {
                return grafo;
            }

            set
            {
                grafo = value;
            }
        }

        public List<Ciudad> CiudadesSolucionFuerzaBruta
        {
            get
            {
                return ciudadesSolucionFuerzaBruta;
            }

            set
            {
                ciudadesSolucionFuerzaBruta = value;
            }
        }

        public int DistanciaFuerzaBruta
        {
            get
            {
                return distanciaFuerzaBruta;
            }

            set
            {
                distanciaFuerzaBruta = value;
            }
        }

        public void agregarCiudad(Ciudad c)
        {
            grafo.agregarVertice(c);
        }

        public List<Ciudad> generarSolucionKruskal()
        {
            var sw = Stopwatch.StartNew();
            cargarAristas();
            List<Ciudad> c= grafo.kruskalPreOrden();
            Console.WriteLine("[Solución Kruskal] - Solución para {0} ciudades en : {1} ", c.Count-1, sw.Elapsed);
            return c;
        }

        private void cargarAristas()
        {
            grafo.Aristas.Clear();
            for(int i = 0; i < grafo.Vertices.Count; i++)
            {
                Ciudad origen = grafo.Vertices[i].Info;
                for(int j = i+1; j < grafo.Vertices.Count; j++)
                {
                    Ciudad destino = grafo.Vertices[j].Info;
                    grafo.agregarArista(origen, destino, origen.calcularDistancia(destino));
                }
            }
            grafo.Aristas.Sort();
        }

        private void Perm2(List<Ciudad> elem, List<Ciudad> act, int n, int r, Ciudad inicioFin)
        {
            if (n == 0)
            {
                int dist = calcularPesoCamino(act, inicioFin);
                if (dist < DistanciaFuerzaBruta)
                {
                    CiudadesSolucionFuerzaBruta.RemoveRange(0, CiudadesSolucionFuerzaBruta.Count);
                    CiudadesSolucionFuerzaBruta.Add(inicioFin);
                    CiudadesSolucionFuerzaBruta.AddRange(act);
                    DistanciaFuerzaBruta = dist;
                }
            }
            else {
                //Console.WriteLine("R ="+r+" N ="+n);
                for (int i = 0; i < r; i++)
                {
                    if (!act.Contains(elem[i]))

                    { // Controla que no haya repeticiones

                        act.Add(elem[i]);
                        //Console.WriteLine("-------------");
                        Perm2(elem, act, n - 1, r, inicioFin);
                        act.RemoveAt(act.Count - 1);
                    }
                }
            }
        }

        private int calcularPesoCamino(List<Ciudad> camino, Ciudad inicioFin)
        {
            int peso = 0;
            if(camino.Count <= 1)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < camino.Count - 1; i++)
                {
                    peso += camino[i].calcularDistancia(camino[i + 1]);
                }
                peso += inicioFin.calcularDistancia(camino[0]);
                peso += camino[camino.Count - 1].calcularDistancia(inicioFin);
                return peso;
            }
        }

        public int calcularDistanciaTotal(List<Ciudad> ciudades)
        {
            int suma = 0;
            for(int i = 0; i < ciudades.Count-1; i++)
            {
                Ciudad c1 = ciudades[i];
                Ciudad c2 = ciudades[i + 1];
                suma += c1.calcularDistancia(c2);
            }
            return suma;
        }

        public List<Ciudad> darCiudades()
        {
            List<Ciudad> ciudades = new List<Ciudad>();
            for (int i =0; i < grafo.Vertices.Count; i++)
            {
                ciudades.Add(grafo.Vertices[i].Info);
            }
            return ciudades;
        }

        public List<Ciudad> generarSolucionFuerzaBruta()
        {
            var sw = Stopwatch.StartNew();
            if (grafo.Vertices.Count == 0)
            {
                return new List<Ciudad>();
            }
            else if(CiudadesSolucionFuerzaBruta.Count > 0)
            {
                return CiudadesSolucionFuerzaBruta;
            }
            else
            {
                List<Ciudad> ciudades = new List<Ciudad>();
                for (int i = 1; i < grafo.Vertices.Count; i++)
                {
                    ciudades.Add(grafo.Vertices[i].Info);
                } 
                List<Ciudad> a = new List<Ciudad>();
                Perm2(ciudades, a, ciudades.Count, ciudades.Count, grafo.Vertices[0].Info);
                CiudadesSolucionFuerzaBruta.Add(grafo.Vertices[0].Info);
                Console.WriteLine("[Solución Fuerza Bruta] - Solución para {0} ciudades en : {1} ", ciudadesSolucionFuerzaBruta.Count-1,sw.Elapsed);
                return CiudadesSolucionFuerzaBruta;
            }
         
        }

        public List<Ciudad> generarSolucionInsercion()
        {
            var sw = Stopwatch.StartNew();
            if (grafo.Vertices.Count > 0)
            {
                if(ciudadesSolucionInsercion.Count > 0)
                {
                    return ciudadesSolucionInsercion;
                }
                else
                {
                    List<Ciudad> vT = grafo.verticesToInfo();
                    Ciudad cInicial = vT[0];
                    vT.RemoveAt(0);
                    List<Ciudad> cTemporal = recorridoInsercion(cInicial, vT);
                    cTemporal.Add(cInicial);
                    Console.WriteLine("[Solución Inserción] - Solución para {0} ciudades en : {1} ", ciudadesSolucionInsercion.Count - 1, sw.Elapsed);
                    return cTemporal;
                }
            }
            else
            {
                return new List<Ciudad>();
            }
            
            
             
           
            
        }

        public List<Ciudad> recorridoInsercion(Ciudad ciudadInicial, List<Ciudad> ciudadesP)
        {
            if(ciudadesP.Count == 0)
            {
                List<Ciudad> cNueva = new List<Ciudad>();
                cNueva.Add(ciudadInicial);
                return cNueva;
            }
            else
            {
                int comparador = int.MaxValue;
                List<Ciudad> menor = new List<Ciudad>();
                for (int i = 0; i < ciudadesP.Count; i++)
                {
                    Ciudad cInicialT = ciudadesP[i];
                    List<Ciudad> cNueva = ciudadesP;
                    cNueva.Remove(cInicialT);
                    List<Ciudad> nuevaLista = recorridoInsercion(cInicialT, cNueva);

                    List<Ciudad> miNuevaLista = new List<Ciudad>();
                    miNuevaLista.Add(ciudadInicial);
                    miNuevaLista.AddRange(nuevaLista);

                    int distancia = calcularDistanciaTotal(miNuevaLista);
                    if(distancia < comparador)
                    {
                        comparador = distancia;
                        menor = miNuevaLista;
                    }
                }
                return menor;
            }
        }

        //public List<Ciudad> recorridoInsercion(Ciudad ciudadInicial, List<Ciudad> ciudadesP)
        //{
        //    int comparador = int.MaxValue;
        //    List<Ciudad> menor = new List<Ciudad>();
        //    for (int i = 0; i < ciudadesP.Count; i++)
        //    {
        //        Ciudad vertice = ciudadesP[i];
        //        List<Ciudad> copiaP = ciudadesP;
        //        copiaP.Remove(vertice);
        //        List<Ciudad> calculado = recorridoInsercion(vertice, copiaP);

        //        List<Ciudad> nuevo = new List<Ciudad>();
        //        nuevo.Add(vertice);
        //        nuevo.AddRange(calculado);

        //        int distancia = calcularDistanciaTotal(nuevo);
        //        if (distancia < comparador)
        //        {
        //            comparador = distancia;
        //            menor = nuevo;
        //        }
        //    }
        //    return menor;
        //}

        public List<String> listaCiudadesString()
        {
            List<String> ciudades = new List<string>();
            foreach(Vertice<Ciudad> ver in grafo.Vertices)
            {
                ciudades.Add(ver.Info.Nombre);
            }
            return ciudades;
        }

        public void eliminarCiudad(Ciudad c)
        {
            List < Vertice < Ciudad >> listaCiudades = new List<Vertice<Ciudad>>();
            listaCiudades = grafo.Vertices;
            foreach (Vertice<Ciudad> v in listaCiudades)
            {
                if (v.Info.Nombre == c.Nombre)
                {
                    grafo.Vertices.Remove(v);
                    break;
                }
            }
        }

        public List<Ciudad> listaCiudades()
        {
            List<Ciudad> ciudades = new List<Ciudad>();
            foreach (Vertice<Ciudad> ver in grafo.Vertices)
            {
                ciudades.Add(ver.Info);
            }
            return ciudades;
        }

        public void filtrarCiudadPorPoblacion(int poblacion)
        {
            for(int i = 0; i < grafo.Vertices.Count; i++)
            {
                Vertice<Ciudad> ver = grafo.Vertices[i];
                if (ver.Info.Poblacion < poblacion)
                {
                    grafo.Vertices.Remove(ver);
                }
            }
        }
    }
}
