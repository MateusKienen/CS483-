using Cs483.ConsoleApp.Aula01._1___Tipos;
using Cs483.ConsoleApp.Aula01._2_TiposInteiros;
using Cs483.ConsoleApp.Aula01._3_PontoFlutuante;
using Cs483.ConsoleApp.Aula01._4_Booleano;
using Cs483.ConsoleApp.Aula01._5_Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcao;

            do
            {
                MontaMenu();
                Console.WriteLine("Digite uma opção");
                opcao = Convert.ToInt32(Console.ReadLine());
                Tipos tipos = new Tipos();
                TiposInteiros tiposInteiros = new TiposInteiros();
                PontoFlutuante pontoFlutuante = new PontoFlutuante();
                Booleano booleano = new Booleano();
                Structs structs = new Structs();
                switch (opcao)
                {
                    case 1:
                        tipos.Executa();
                        break;
                    case 2:
                        tiposInteiros.Executa();
                        break;
                    case 3:
                        pontoFlutuante.Executa();
                        break;
                    case 4:
                        booleano.Executa();
                        break;
                    case 5:
                        structs.Executa();
                        break;
                    default:
                        break;
                }
                Console.ReadLine();


                Console.Clear();
            } while (opcao != 0);

        }

        private static void MontaMenu()
        {
            Console.WriteLine("===========  CS 483  ===========");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Tipos por Valor");
            Console.WriteLine("2 - Tipos Inteiros");
            Console.WriteLine("3 - Ponto Flutuante");
            Console.WriteLine("4 - Booleano");
            Console.WriteLine("5 - Structs");
            Console.WriteLine("6 - ");
            Console.WriteLine("7 - ");
            Console.WriteLine("8 - ");
            Console.WriteLine("9 - ");
            Console.WriteLine("10 - ");


        }
    }
}
