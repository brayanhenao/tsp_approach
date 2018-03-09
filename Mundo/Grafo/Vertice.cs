using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mundo
{
    public class Vertice<T>
    {
        //Atributos
        private T info;

        //Constructor
        public Vertice(T info)
        {
            this.info = info;
        }

        //Métodos
        public T Info
        {
            get
            {
                return info;
            }

            set
            {
                info = value;
            }
        }
    }
}
