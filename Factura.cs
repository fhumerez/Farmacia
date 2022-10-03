using System;
using System.Collections.Generic;

namespace Farmacia
{
    public partial class Factura
    {
        public int NumFactura { get; set; }
        public DateTime Fecha { get; set; }
        public int Ci { get; set; }
        public int Nit { get; set; }

        public virtual Farmaceutico CiNavigation { get; set; } = null!;
        public virtual Cliente NitNavigation { get; set; } = null!;
    }
}
