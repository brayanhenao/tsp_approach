using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mundo
{
    public class Pagina
    {
        private int npagina;
        private int nlineainicio;
        private int nlineaFinal;

        public int Npagina
        {
            get
            {
                return npagina;
            }

            set
            {
                npagina = value;
            }
        }

        public int Nlineainicio
        {
            get
            {
                return nlineainicio;
            }

            set
            {
                nlineainicio = value;
            }
        }

        public int NlineaFinal
        {
            get
            {
                return nlineaFinal;
            }

            set
            {
                nlineaFinal = value;
            }
        }

        public Pagina(int npagina, int nlinea)
        {
            this.Npagina = npagina;
            this.Nlineainicio = nlinea;
            NlineaFinal = Nlineainicio + Viajero.NUMERO_A_CARGAR;
        }
    }
}
