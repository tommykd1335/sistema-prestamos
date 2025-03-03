using System.Threading.Tasks;

namespace BancoM_Asocio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear cliente
            Cliente cliente1 = new Cliente
            {
                Cedula = "123456789",
                Nombre = "Juan",
                Apellido = "Perez",
                Direccion = "Calle Duarte #12",
                Telefono = "809-241-5482"
            };
            Cliente cliente2 = new Cliente
            {
                Cedula = "987654321",
                Nombre = "Maria",
                Apellido = "Gonzalez",
                Direccion = "Avenida Central #45",
                Telefono = "809-555-1234"
            };
            Cliente cliente3 = new Cliente
            {
                Cedula = "456789123",
                Nombre = "Carlos ",
                Apellido = "Ramirez",
                Direccion = "Calle Primavera #78",
                Telefono = "809-333-9876"
            };

            //Crear prestamos
            Prestamos prestamo1 = new Prestamos
            {
                Codigo = 1,
                Monto = 10000,
                FechaBeg = DateTime.Now,
                FechaEnd = DateTime.Now.AddYears(1),
                Interes = 0.03,
                Prestatario = cliente1,
                Fiador = cliente2,
                Garantia = new Garantia
                {
                    Codigo = 1,
                    Tipo = "Vehiculo",
                    Valor = 50000,
                    Ubicacion = "Calle Duarte #1"
                }
            };
            prestamo1.CuotaPrestamo = new List<CuotaPrestamos>();
            for (int i = 0; i <= 12; i++)
            {
                prestamo1.CuotaPrestamo.Add(new CuotaPrestamos
                {
                    FechaRealizado = DateTime.Now,
                    FechaPlanificado = DateTime.Now.AddMonths(i),
                    Monto = prestamo1.Monto / 12,
                    TipoPago = "Deposito Bancario"

                });
            }

            Prestamos prestamo2 = new Prestamos
            {
                Codigo = 2,
                Monto = 15000,
                FechaBeg = DateTime.Now,
                FechaEnd = DateTime.Now.AddYears(2),
                Interes = 0.03,
                Prestatario = cliente3,  
                Fiador = cliente1,       
                Garantia = new Garantia
                {
                    Codigo = 2,
                    Tipo = "Casa",
                    Valor = 100000,
                    Ubicacion = "Avenida Central #20"
                }
            };
            prestamo2.CuotaPrestamo = new List<CuotaPrestamos>();
            for (int i = 0; i <= 12; i++)
            {
                prestamo2.CuotaPrestamo.Add(new CuotaPrestamos
                {
                    FechaRealizado = DateTime.Now,
                    FechaPlanificado = DateTime.Now.AddMonths(i),
                    Monto = prestamo2.Monto / 12,
                    TipoPago = "Deposito Bancario" 
                });
            }
            Inversiones inversion1 = new Inversiones
            {   Codigo = 2,
                Monto = 100000,
                Interes = 0.03,
                FechaBeg = DateTime.Now,
                FechaEnd = DateTime.Now.AddYears(5),
                Inversionista= cliente2
            };
            inversion1.CuotaInversion = new List<CuotasInversiones>();
            for (int i = 0; i <= 60 ; i++)
            {
                inversion1.CuotaInversion.Add(new CuotasInversiones
                {
                    FechaPlanificada = DateTime.Now.AddYears(i),
                    Monto = inversion1.Monto * inversion1.Interes/ 12,
                    Tipo = "Deposito Bancario"
                });
            }

            Inversiones inversion2 = new Inversiones
            {
                Codigo = 3,
                Monto = 200000,
                Interes = 0.03,
                FechaBeg = DateTime.Now,
                FechaEnd = DateTime.Now.AddYears(3),
                Inversionista = cliente3  
            };
            inversion2.CuotaInversion = new List<CuotasInversiones>();
            for (int i = 0; i <= 36; i++)
            {
                inversion2.CuotaInversion.Add(new CuotasInversiones
                {
                    FechaPlanificada = DateTime.Now.AddYears(i),
                    Monto = inversion2.Monto * inversion2.Interes / 12,
                    Tipo = "Deposito Bancario"
                });
            }

            //Mostrar informacion del protamo
            Console.WriteLine("Informacion del pretamo:");
            Console.WriteLine($"Cliente: {prestamo1.Prestatario.Nombre} " + 
                $"{ prestamo1.Prestatario.Apellido}");
            Console.WriteLine($"Monto del prestamo: {prestamo1.Monto}");
            Console.WriteLine("Cuotas de pago: ");
            foreach (var cuota in prestamo1.CuotaPrestamo) 
            {
                Console.WriteLine($"- Fecha planificada: {cuota.FechaPlanificado}"+ 
                    $", Mosto: {cuota.Monto}, Tipo de pago: {cuota.TipoPago}");
            }

            Console.WriteLine();

            //Mostrar informacion de la inversion
            Console.WriteLine("Informacion de inversiones:");
            Console.WriteLine($"Cliente: {inversion1.Inversionista.Nombre} " +
                $"{inversion1.Inversionista.Apellido}");
            Console.WriteLine($"Monto de inversion: {inversion1.Monto}");
            Console.WriteLine("Cuotas de pago: ");
            foreach (var cuota in inversion1.CuotaInversion)
            {
                Console.WriteLine($"- Fecha planificada: {cuota.FechaPlanificada}" +
                    $", Mosto: {cuota.Monto}, Tipo de pago: {cuota.Tipo}");
            }
        }
    }
}
