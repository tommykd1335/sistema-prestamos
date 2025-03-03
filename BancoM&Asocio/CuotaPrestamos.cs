using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoM_Asocio
{
    internal class CuotaPrestamos
    {
        public DateTime FechaPlanificado { get; set; }
        public double Monto { get; set; }
        public DateTime FechaRealizado { get; set; }
        public double CodigoComprobante { get; set; }
        public string TipoPago { get; set; }

    }
}
