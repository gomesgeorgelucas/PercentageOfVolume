using System.Globalization;

namespace PercentageOfVolume
{
    public class Program
    {
        private static decimal PorcercentagemInteira { get; } = 1.0M;
        private static decimal PorcentagemVazio { get; } = 0.0M;
        private static int MinimoNegociavel { get; } = 1;

        public static int funcaoRetornaQuantitadePOV(decimal porcentagem, int totalNegociado)
        {
            if (porcentagem < PorcentagemVazio || porcentagem >= PorcercentagemInteira)
            {
                return default;
            }

            if (totalNegociado < MinimoNegociavel)
            {
                return default;
            }

            decimal porcentagemDoTotal;
            try
            {
                porcentagemDoTotal = decimal.Subtract(PorcercentagemInteira, porcentagem);
            }
            catch (Exception)
            {
                Console.WriteLine($"Error subtracting {porcentagem} from {PorcercentagemInteira}.");
                porcentagemDoTotal = 1.0M;
            }

            decimal pov;
            try
            {
                pov = decimal.Divide((totalNegociado * porcentagem), porcentagemDoTotal);
            }
            catch (Exception)
            {
                Console.WriteLine($"Error dividing {totalNegociado * porcentagem} by {porcentagemDoTotal}.");
                pov = default;
            }

            return (int)Math.Truncate(pov);
        }

        static void Main(string[] args)
        {
            int[] totaisNegociados = new int[] { 90, 100, 70, 81, 80, 10, 1, 99, 98 };

            decimal[] porcentagens = new decimal[] { 0.1M, 0.1M, 0.2M, 0.4M, 0.2M, 0.9M, 0.99M, 0.01M, 0.02M };

            int[] povs = new int[] { 10, 11, 17, 54, 20, 90, 99, 1, 2 };

            for (var teste = 0; teste < totaisNegociados.Length; teste++)
            {
                int povAtual = funcaoRetornaQuantitadePOV(porcentagens[teste], totaisNegociados[teste]);
                if (povAtual == povs[teste])
                {
                    Console.WriteLine($"Teste {teste + 1} - PASS! - ({porcentagens[teste].ToString(new CultureInfo("en-US"))}, {totaisNegociados[teste]}) => {povs[teste]}");
                }
                else
                {
                    Console.WriteLine($"Teste {teste + 1} - FAIL! - ({porcentagens[teste].ToString(new CultureInfo("en-US"))}, {totaisNegociados[teste]}) => Expected: {povs[teste]}, Got: {povAtual}");
                }
            }
        }
    }
}