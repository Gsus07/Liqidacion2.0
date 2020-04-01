using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Subsidiado : LiquidacionCuotaModeradora
    {
        public Subsidiado(int numeroLiquidacion, string identificacion, decimal valorServicio) : base(numeroLiquidacion, identificacion, "Subsidiado", valorServicio, 0)
        {
        }

        public override decimal Tarifa { get { return 0.05m; } }

        public override int TopeMaximo
        {
            get
            {
                return 200000;
            }
        }
    }
}
