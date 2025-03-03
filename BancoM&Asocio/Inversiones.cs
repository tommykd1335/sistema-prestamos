using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoM_Asocio
{
    internal class Inversiones:Transaccion
    {
        public Cliente Inversionista { get; set; }
        public  List<CuentaBancos> CuentaBanco { get; set; }
        public List<CuotasInversiones> CuotaInversion{ get; set; }
    }
}
