using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LiquidacionCuotaModeradoraRepository
    {
        public LiquidacionCuotaModeradoraRepository()
        {

        }

        public bool GuardarLiquidacion(LiquidacionCuotaModeradora liquidacionCuota)
        {
            return true;
        }

        public List<LiquidacionCuotaModeradora> ObtenerLiquidaciones()
        {
            List<LiquidacionCuotaModeradora> liquidacionCuotaModeradoras = new List<LiquidacionCuotaModeradora>();


            return liquidacionCuotaModeradoras;
        }

        public bool EliminarLiquidacion(int numeroLiquidacion)
        {
            return false;
        }
    }
}
