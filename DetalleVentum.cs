using System;
using System.Collections.Generic;

namespace Farmacia
{
    public partial class DetalleVentum
    {
        public int Id   { get; set; }
        public int NumFactura { get; set; }
        public string CodMedic { get; set; } = null!;
        public int Cantidad { get; set; }

        public virtual Medicamento CodMedicNavigation { get; set; } = null!;
        public virtual Factura NumFacturaNavigation { get; set; } = null!;
    }
}
