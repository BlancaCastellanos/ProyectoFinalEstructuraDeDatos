using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuraDeDatos
{
    class PS : Peliculas
    {

        //SERIES - VARIABLES
        public PS (string titulo, int año, string temporadas, string descripcion, string rating, string genero, string productor)

        {
            this.Titulo = titulo;
            this.Año = año;
            this.Temporadas = temporadas;
            this.Descripcion = descripcion;
            this.Rating = rating;
            this.Genero = genero;
            this.Productor = productor;
        }

        //PELICULAS - VARIABLES
        public PS(string titulo, int año, int duracionminutos, string sinopsis, string director, string rating, string genero)
        {
            this.Titulo = titulo;
            this.Año = año;
            this.DuracionMinutos = duracionminutos;
            this.Sinopsis = sinopsis;
            this.Director = director;
            this.Rating = rating;
            this.Genero = genero;
            
        }
    }
}
