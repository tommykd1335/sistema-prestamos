using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoM_Asocio
{
    internal class Transaccion
    {
        public int Codigo { get; set; }
        public double Monto { get; set; }
        public DateTime FechaBeg { get; set; }
        public DateTime FechaEnd{ get; set; }
        public double Interes { get; set; }
        public List<CuotasInversiones> CuotaInversion { get; set; }
        public List<CuentaBancos> CuentaBanco { get; set; }
    }
}
