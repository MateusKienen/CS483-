using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula01._4_Booleano
{
    class Booleano
    {
        public void Executa()
        {
            Console.WriteLine("Booleano");
            //ExibeBooleano();

            double a = 10.10;
            double b = 20.20;
            double resultado = a + b;
            Console.WriteLine($"valor resultado = 30.30 - {resultado == 30.30}");

        }

        private static void ExibeBooleano()
        {
            double a = 10;
            double b = 20;
            double resultado = a + b;
            Console.WriteLine($"valor igual {resultado}");
            /**
             * if de uma linha,  primeiro parametro é o verdadeiro e o segundo é o falso. "Sim" : "Não"
             * string checagem = resultado == 30 ? "Sim" : "Não";
            */
            Console.WriteLine($"valor resultado = 30 - {resultado == 30}");
            Console.WriteLine($"valor resultado = 30 - {(resultado == 30 ? "Sim" : "Não")}");
        }
    }
}
