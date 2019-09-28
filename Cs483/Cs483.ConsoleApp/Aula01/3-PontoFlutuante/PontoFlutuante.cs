using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula01._3_PontoFlutuante
{
    class PontoFlutuante
    {
        public void Executa()
        {
            Console.WriteLine("Ponto Flutuante\n\n");
            Float();
            Double();
            ExibirPontoFlutuante();

            decimal salario = 1050.00m;
            Console.WriteLine($"salario professor {salario}");
            decimal adicional = 80.00m;
            decimal soma = salario + adicional;
            Console.WriteLine($"salario professor {salario} + adicional {adicional}  = {soma}");

        }

        private static void Double()
        {
            double vlCerva = 6.15;
            double vlCervaA = 2.1;
            double somaA = vlCerva + vlCervaA;
            Console.WriteLine($"vlB:  { vlCerva}  + vlBA: {vlCervaA} = {somaA}\n");
            if ((vlCerva + vlCervaA) == somaA)
            {
                Console.WriteLine("É igual");
            }
            if (somaA == 8.25)
            {
                Console.WriteLine("Soma igual a 8.25");
            }
            double massaT = 5.972e24;
            Console.WriteLine($"Massa da terra: {massaT}");
        }

        private static void Float()
        {
            float vlBeer = 6.32f;
            float vlBeerA = 2.15f;
            float soma = vlBeer + vlBeerA;
            Console.WriteLine($"vlB:  { vlBeer}  + vlBA: {vlBeerA} = {soma}\n");
        }

        private static void ExibirPontoFlutuante()
        {

            //==== float  => Single
            Console.WriteLine($"Valor Mínimo : {float.MinValue}");
            Console.WriteLine($"Valor Máximo : {float.MaxValue}\n");

            //==== double  => Double
            Console.WriteLine($"Valor Mínimo : {double.MinValue}");
            Console.WriteLine($"Valor Máximo : {double.MaxValue}\n");
            //==== decimal  => Decimal
            Console.WriteLine($"Valor Mínimo : {decimal.MinValue}");
            Console.WriteLine($"Valor Máximo : {decimal.MaxValue}\n");
        }
    }
}
