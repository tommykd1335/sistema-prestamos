using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoM_Asocio
{
    internal class Cliente
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; } 
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public List<CuentaBancos> CuentaBanco { get; set; }
        public List<Prestamos> Prestamo { get; set; }
        public List<Inversiones> Inversion { get; set; }
    }
}
