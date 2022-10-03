using System;
using System.Collections.Generic;

namespace Farmacia
{
    public partial class Medicamento
    {
        public string CodMed { get; set; } = null!;
        public DateTime FechaExp { get; set; }
        public string NombreMedic { get; set; } = null!;
        public string? Descripcion { get; set; }
    }
}
