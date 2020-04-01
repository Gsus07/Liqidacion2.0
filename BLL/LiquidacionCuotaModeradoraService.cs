using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LiquidacionCuotaModeradoraService
    {
        private readonly LiquidacionCuotaModeradoraRepository moderadoraRepository;
        public LiquidacionCuotaModeradoraService()
        {
            moderadoraRepository = new LiquidacionCuotaModeradoraRepository();
        }

        public bool GuardarLiquidacion(LiquidacionCuotaModeradora liquidacion)
        {
            return moderadoraRepository.GuardarLiquidacion(liquidacion);
        }

        public List<LiquidacionCuotaModeradora> ObtenerLiquidaciones()
        {
            return moderadoraRepository.ObtenerLiquidaciones();
        }

        public bool EliminarLiquidacion(int numeroLiquidacion)
        {
            return moderadoraRepository.EliminarLiquidacion(numeroLiquidacion);
        }
    }
}
