using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoM_Asocio
{
    internal class Prestamos : Transaccion
    {
        public Cliente Prestatario { get; set; }
        public Cliente Fiador { get; set; }
        public Garantia Garantia { get; set; }
        public List<CuotaPrestamos> CuotaPrestamo { get; set; }
    }
}
