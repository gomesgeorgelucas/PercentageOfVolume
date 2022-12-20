using System.Globalization;

namespace PercentageOfVolume
{
    public class Program
    {
        public static int funcaoRetornaQuantitadePOV(decimal porcentagem, int totalNegociado)
        {
            decimal porcentagemDoTotal = 1.0M - porcentagem;
            int pov = (int)Math.Truncate(((totalNegociado * porcentagem) / porcentagemDoTotal));

            return pov;
        }
        static void Main(string[] args)
        {
            int[] totaisNegociados = new int[] { 90, 100, 70, 81 };

            decimal[] porcentagens = new decimal[] { 0.1M, 0.1M, 0.2M, 0.4M };

            int[] povs = new int[] { 10, 11, 17, 54 };

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