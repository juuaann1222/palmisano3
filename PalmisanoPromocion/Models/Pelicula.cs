using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PalmisanoPromocion.Models
{
    public class Pelicula
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public DateTime FechaEstreno { get; set; }

        public string Foto { get; set; }

        public string Trailer { get; set; }

        public string Resumen  { get; set; }

        public int GeneroId { get; set; }

        public Genero Genero { get; set; }

        public ICollection<PeliculaActor> Actores { get; set; }


    }
}
