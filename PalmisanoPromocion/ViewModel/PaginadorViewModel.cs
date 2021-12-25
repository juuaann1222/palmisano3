using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PalmisanoPromocion.ViewModel
{
    public class PaginadorViewModel
    {
        public int PaginaActual { get; set; }
        public int TotalRegistros { get; set; }
        public int RegistrosPorPagina { get; set; }
        public int TotalPaginas => (int)Math.Ceiling((decimal)TotalRegistros / RegistrosPorPagina);

        public Dictionary<String, String> ValoresQueryString { get; set; } = new Dictionary<string, string>();
    }
}
