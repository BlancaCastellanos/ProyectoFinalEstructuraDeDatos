using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuraDeDatos
{
    class Peliculas : Series
    {
        public int DuracionMinutos { get; set; }
        public string Sinopsis { get; set; }
        public string Director { get; set; }
    }
}
