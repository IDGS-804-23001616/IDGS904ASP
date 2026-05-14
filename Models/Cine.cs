using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904ASP.Models
{
    public class Cine
    {
        public string Nombre { get; set; }

        public int CantidadCompradores { get; set; }

        public int CantidadBoletas { get; set; }

        public bool TarjetaCineco { get; set; }

        public double TotalPagar { get; set; }
    }
}
