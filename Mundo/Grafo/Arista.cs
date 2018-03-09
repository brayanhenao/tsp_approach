using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mundo
{
    public class Arista<T> : IComparable<Arista<T>>
    {
        //Atributos
        private Vertice<T> origen;
        private Vertice<T> destino;
        private int distancia;

        //Constructor
        public Arista(T origen, T destino, int distancia)
        {
            this.origen = new Vertice<T>(origen);
            this.destino = new Vertice<T>(destino);
            this.distancia = distancia;
        }

        public Arista(Vertice<T> origen, Vertice<T> destino, int distancia)
        {
            this.origen = origen;
            this.destino = destino;
            this.distancia = distancia;
        }

        //Métodos
        public Vertice<T> Origen
        {
            get
            {
                return origen;
            }

            set
            {
                origen = value;
            }
        }

        public Vertice<T> Destino
        {
            get
            {
                return destino;
            }

            set
            {
                destino = value;
            }
        }

        public int Distancia
        {
            get
            {
                return distancia;
            }

            set
            {
                distancia = value;
            }
        }

        public int CompareTo(Arista<T> other)
        {
            return distancia - other.distancia;
        }
    }
}
