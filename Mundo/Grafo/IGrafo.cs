using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mundo
{
    public interface IGrafo<T>
    {
        void agregarArista(Vertice<T> v1, Vertice<T> v2, int ponderacion);
        void agregarArista(T v1, T v2, int ponderacion);
        void agregarVertice(Vertice<T> v);
        void agregarVertice(T v);

    }
}
