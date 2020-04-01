namespace Entity
{
    public class Contributiva : LiquidacionCuotaModeradora
    {
        public Contributiva(int numeroLiquidacion, string identificacion, decimal valorServicio, decimal salario) : base(numeroLiquidacion, identificacion, "Contributiva", valorServicio, salario)
        {

        }

        public override decimal Tarifa
        {
            get
            {
                if (SalarioPaciente < 2)
                {
                    return 0.15m;
                }
                else if (SalarioPaciente <= 5)
                {
                    return 0.20m;
                }
                else
                {
                    return 0.25m;
                }
            }
        }

        public override int TopeMaximo
        {
            get
            {
                if (SalarioPaciente < 2)
                    return 250000;
                else if (SalarioPaciente <= 5)
                    return 900000;
                else
                    return 15000000;
            }
        }
    }
}
