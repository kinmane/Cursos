namespace ExerPropostoMembrosEstaticos
{
    public class ConversorDeMoeda
    {
        public static double IOF = 0.06;

        public static double DolarParaReal(double cotacao, double valor)
        {
            return cotacao * valor * (1.0 + IOF);
        }        
    }
}

