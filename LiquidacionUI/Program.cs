using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace LiquidacionUI
{
    class Program
    {
        static void Main(string[] args)
        {
            LiquidacionCuotaModeradora contributiva = new Contributiva(223, "923456", 10000000, 2);
            LiquidacionCuotaModeradora subsidiada = new Subsidiado(322, "183457", 100000);

            
            contributiva.LiquidarCuota();
            subsidiada.LiquidarCuota();
            ImprimirLiquidacion(contributiva);
            Console.WriteLine("");
            Console.WriteLine("");
            ImprimirLiquidacion(subsidiada);

            Console.ReadKey();
        }

        static void ImprimirLiquidacion(LiquidacionCuotaModeradora liquidacionCuota)
        {
            Console.WriteLine("Numero Liquidacion: " + liquidacionCuota.NumeroLiquidacion);
            Console.WriteLine("Identificacion paciente: " + liquidacionCuota.IdentificacionPaciente);
            Console.WriteLine("Salario paciente: " + liquidacionCuota.SalarioPaciente);
            Console.WriteLine("Tipo de afiliacion: " + liquidacionCuota.TipoAfilicion);
            Console.WriteLine("Valor Servicio: " + liquidacionCuota.ValorServicio);
            Console.WriteLine("Tarifa: " + liquidacionCuota.Tarifa);
            Console.WriteLine("Tope: " + liquidacionCuota.TopeMaximo);
            Console.WriteLine("Cuota a pagar: " + liquidacionCuota.ValorCuota);
        }
    }
}
