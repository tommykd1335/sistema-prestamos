using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoM_Asocio
{
    internal class CuotasInversiones 
    {
        public DateTime FechaPlanificada { get; set; }
        public double Monto { get; set; }
        public string Tipo { get; set; }
        public DateTime FechaRealizada { get; set; }
        public double CodigoComprobante { get; set; }
        
    }
}
