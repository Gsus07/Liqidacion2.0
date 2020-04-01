using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class LiquidacionCuotaModeradora { 
        public int NumeroLiquidacion { get; set; }
        public string IdentificacionPaciente { get; set; }
        public string TipoAfilicion { get; set; }
        public decimal ValorServicio { get; set; }
        public decimal SalarioPaciente { get; set; }

        public decimal ValorCuota { get; set; }
        public abstract int TopeMaximo { get; }
        public abstract decimal Tarifa { get; }


        public LiquidacionCuotaModeradora(int numeroLiquidacion, string identificacion, string tipoAfilicion, decimal valorServicio, decimal salario)
        {
            NumeroLiquidacion = numeroLiquidacion;
            IdentificacionPaciente = identificacion;
            TipoAfilicion = tipoAfilicion;
            ValorServicio = valorServicio;
            SalarioPaciente = salario;
        }

        public void LiquidarCuota()
        {
            decimal cuota = ValorServicio * Tarifa;
            ValorCuota = TopeMaximo;
            if (cuota <= TopeMaximo)
            {
                ValorCuota = cuota;
            }
        }
    }
}
