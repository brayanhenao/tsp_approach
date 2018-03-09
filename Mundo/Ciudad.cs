using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mundo
{
    public class Ciudad
    {
        //Atributos
        private String nombre;
        private double latitud;
        private double longitud;
        private int poblacion;

        public const int RADIO_TIERRA = 6371;

        //Constructor
        public Ciudad(string nombre, double latitud, double longitud, int poblacion)
        {
            this.Nombre = nombre;
            this.Latitud = latitud;
            this.Longitud = longitud;
            this.Poblacion = poblacion;
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

        public double Latitud
        {
            get
            {
                return latitud;
            }

            set
            {
                latitud = value;
            }
        }

        public double Longitud
        {
            get
            {
                return longitud;
            }

            set
            {
                longitud = value;
            }
        }

        public int Poblacion
        {
            get
            {
                return poblacion;
            }

            set
            {
                poblacion = value;
            }
        }

        public int calcularDistancia(Ciudad point2)
        {
            double Lat = (point2.Latitud - this.Latitud) * (Math.PI / 180);
            double Lon = (point2.Longitud - this.Longitud) * (Math.PI / 180);
            double a = Math.Sin(Lat / 2) * Math.Sin(Lat / 2) +
                    Math.Cos(this.Latitud * (Math.PI / 180)) * Math.Cos(point2.Latitud * (Math.PI / 180)) *
                    Math.Sin(Lon / 2) * Math.Sin(Lon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return (int)(RADIO_TIERRA * c);
        }
    }
}
