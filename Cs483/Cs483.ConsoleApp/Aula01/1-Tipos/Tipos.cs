using Cs483.ConsoleApp.Aula01._1_Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula01._1___Tipos
{
    public class Tipos
    {
        public void Executa()
        {
            Console.WriteLine("Tipos \n");

            //ExibeNumeros();
            //ExibeCervejas();
            ExibeTiposPorValor();
        }

        public void ExibeCervejas()
        {
            Beer b = new Beer();
            b.Graduacao = "18%";
            b.Cor = "Turva";
            b.IBU = 17;

            Beer b2 = new Beer();
            b2.Graduacao = "34%";
            b2.Cor = "Clara";
            b2.IBU = 15;

            Console.WriteLine($"Beer1 : {b.ToString()}");
            Console.WriteLine($"Beer2 : {b2.ToString()}");

            b2 = b;
            b.Graduacao = "50%";
            b.Cor = "Escura";
            b.IBU = 25;
            Console.WriteLine($"Beer1 : {b.ToString()}");
            Console.WriteLine($"Beer2 : {b2.ToString()}");
        }

        private static void ExibeNumeros()
        {
            int numero1 = 20;
            int numCopia = 0;
            Console.WriteLine($"Numero1 :  {numero1} ");
            Console.WriteLine($"Copia :  {numCopia} ");

            numCopia = numero1;
            numero1 = 30;
            Console.WriteLine($"Numero1 :  {numero1} ");
            Console.WriteLine($"Copia :  {numCopia} ");
        }

        private void ExibeTiposPorValor()
        {
            //==== short  => int16
            Console.WriteLine($"Valor Mínimo : {short.MinValue}");
            Console.WriteLine($"Valor Máximo : {short.MaxValue}");

            //==== int  => int32
            Console.WriteLine($"Valor Mínimo : {int.MinValue}");
            Console.WriteLine($"Valor Máximo : {int.MaxValue}");

            //==== long  => int64
            Console.WriteLine($"Valor Mínimo : {Int64.MinValue}");
            Console.WriteLine($"Valor Máximo : {Int64.MaxValue}");

        }
    }
}
