using System;
using System.Collections.Generic;

namespace Farmacia
{
    public partial class Farmaceutico
    {
        public Farmaceutico()
        {
            Facturas = new HashSet<Factura>();
        }

        public int Ci { get; set; }
        public string Usuario { get; set; } = null!;
        public string NombreFarm { get; set; } = null!;
        public string ApellidoFarm { get; set; } = null!;
        public string Contrasena { get; set; } = null!;
        public string Cargo { get; set; } = null!;

        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
