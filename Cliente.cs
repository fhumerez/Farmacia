using System;
using System.Collections.Generic;

namespace Farmacia
{
    public partial class Cliente
    {
        public Cliente()
        {
            Facturas = new HashSet<Factura>();
        }

        public int Nit { get; set; }
        public string NombreCliente { get; set; } = null!;
        public string ApellidoCliente { get; set; } = null!;

        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
