using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PalmisanoPromocion.Models
{
    public class PeliculaActor
    {
        [Display(Name = "Pelicula")]
        public int PeliculaId { get; set; }

        [Display(Name = "Actor")]
        public int PersonaId { get; set; }

        public Pelicula Pelicula { get; set; }

        public Persona Persona { get; set; }

    }
}
