using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mundo
{
    public class Grafo<T> : IGrafo<T>
    { 
        //Atributos
        private List<Vertice<T>> vertices;
        private List<Arista<T>> aristas;
        private List<Arista<T>> aristasMST;
        private Dictionary<T, T> raices;

        //Constructor
        public Grafo()
        {
            vertices = new List<Vertice<T>>();
            aristas = new List<Arista<T>>();
            aristas = new List<Arista<T>>();
            raices = new Dictionary<T, T>();
            aristasMST = new List<Arista<T>>();
        }

        //Métodos
        public List<Vertice<T>> Vertices
        {
            get
            {
                return vertices;
            }

            set
            {
                vertices = value;
            }
        }

        public List<Arista<T>> Aristas
        {
            get
            {
                return aristas;
            }

            set
            {
                aristas = value;
            }
        }

   

        public void agregarArista(Vertice<T> v1, Vertice<T> v2, int ponderacion)
        {
            aristas.Add(new Arista<T>(v1, v2, ponderacion));
        }

        public void agregarArista(T v1, T v2, int ponderacion)
        {
            aristas.Add(new Arista<T>(v1, v2, ponderacion));
        }

        public void agregarVertice(Vertice<T> v)
        {
            vertices.Add(v);
            raices.Add(v.Info, v.Info);
        }

        public void agregarVertice(T v)
        {
            vertices.Add(new Vertice<T>(v));
        }
        
        public List<T> verticesToInfo()
        {
            List<T> agregados = new List<T>();
            foreach(Vertice<T> miV in vertices)
            {
                agregados.Add(miV.Info);
            }
            return agregados;
        }

        //-----------------------------------------------------------------------------
        //PRIMERA SOLUCIÓN: KRUSKAL Y RECORRIDO EN PREORDEN
        public List<T> kruskalPreOrden()
        {
            kruskalMTS();
            if(vertices.Count > 0)
            {
                return preOrden(vertices[0].Info);
            }
            else
            {
                return new List<T>();
            }

        }

        private T buscarRaiz(T nombre)
        {
            if (nombre.Equals(raices[nombre]))
            {
                return nombre;
            }
            else
            {
                return buscarRaiz(raices[nombre]);
            }
        }

        private void union(T x, T y)
        {
            T padreX = buscarRaiz(x);
            T padreY = buscarRaiz(y);
            raices[padreX] = padreY;
        }

        private bool mismaComponente(T x, T y)
        {
            return buscarRaiz(x).Equals(buscarRaiz(y));
        }

        private void kruskalMTS()
        {
            raices.Clear();
            foreach(Vertice<T> ver in vertices)
            {
                raices.Add(ver.Info, ver.Info);
            }
            aristasMST.Clear();
            T origen, destino;
            for (int i = 0; i < aristas.Count; i++)
            {
                origen = aristas[i].Origen.Info;
                destino = aristas[i].Destino.Info;

                if (!mismaComponente(origen, destino))
                {
                    aristasMST.Add(aristas[i]);
                    union(origen, destino);
                }
            }
        }

        private List<T> obtenerHijos(T nombre)
        {
            List<T> hijos = new List<T>();
            List<Arista<T>> borradas = new List<Arista<T>>();
            for (int i = 0; i < aristasMST.Count; i++)
            {
                Arista<T> arista = aristasMST[i];
                if (arista.Origen.Info.Equals(nombre) || arista.Destino.Info.Equals(nombre))
                {
                    if (arista.Origen.Info.Equals(nombre))
                    {
                        hijos.Add(arista.Destino.Info);
                    }
                    else {
                        hijos.Add(arista.Origen.Info);
                    }
                    aristasMST.RemoveAt(i);
                }
            }
            //while(borradas.Count > 0)
            //{
            //    aristasMST.Remove(borradas[0]);
          //  }
            return hijos;
        }

        public List<T> preOrden(T ciudad)
        {
            List<T> temp = auxPreOrden(ciudad);
            temp.Add(ciudad);
            return temp;
        }

        public List<T> auxPreOrden(T ciudad)
        {
            List<T> nodos = new List<T>();
            nodos.Add(ciudad);
            List<T> hijos = obtenerHijos(ciudad);
            foreach (T hijo in hijos)
            {
                List<T> temp = auxPreOrden(hijo);
                foreach (T miHijo in temp)
                {
                    nodos.Add(miHijo);
                }
            }
            return nodos;
        }
        //-----------------------------------------------------------------------------
    }
}
