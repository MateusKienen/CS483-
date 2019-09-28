using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula01._2_TiposInteiros
{
    class TiposInteiros
    {
        public void Executa()
        {
            Console.WriteLine("Tipos Inteiros");
            Conversoes();
            ExibeTiposPorInteiros();

        }

        private static void Conversoes()
        {
            char l = 'M';
            int n = l;
            Console.WriteLine($"Letra: {n}");
            int idM = 381;
            byte idade = (byte)idM;
            Console.WriteLine($"Idade Mateus : {idade}");
        }

        private void ExibeTiposPorInteiros()
        {
            //==== char  => Char
            Console.WriteLine($"Valor Mínimo : {char.MinValue}");
            Console.WriteLine($"Valor Máximo : {char.MaxValue}\n");

            //==== byte  => SByte
            Console.WriteLine($"Valor Mínimo : {sbyte.MinValue}");
            Console.WriteLine($"Valor Máximo : {sbyte.MaxValue}\n");

            //==== byte => Byte
            Console.WriteLine($"Valor Mínimo : {byte.MinValue}");
            Console.WriteLine($"Valor Máximo : {byte.MaxValue}\n");


            //==== ushort  => ushort
            Console.WriteLine($"Valor Mínimo : {ushort.MinValue}");
            Console.WriteLine($"Valor Máximo : {ushort.MaxValue}\n");
            //==== short  => int16
            Console.WriteLine($"Valor Mínimo : {short.MinValue}");
            Console.WriteLine($"Valor Máximo : {short.MaxValue}\n");
            
            
            //==== int  => int32
            Console.WriteLine($"Valor Mínimo : {int.MinValue}");
            Console.WriteLine($"Valor Máximo : {int.MaxValue}\n");
            //==== int  => Uint32
            Console.WriteLine($"Valor Mínimo : {uint.MinValue}");
            Console.WriteLine($"Valor Máximo : {uint.MaxValue}\n");


            //==== long  => int64
            Console.WriteLine($"Valor Mínimo : {Int64.MinValue}");
            Console.WriteLine($"Valor Máximo : {Int64.MaxValue}\n");

        }
    }
}
