using ClassLibrary.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {

        public static void Main(string[] args)
        {
            List<object> lista = new List<object>();
            PessoaFisica pessoa = new PessoaFisica();

            pessoa.Nome = "Mateus KLienen";
            pessoa.CPF = "08207696907";
            pessoa.Id = 1;
            pessoa.Email = "mkienen123@gmail.com";

            PessoaJuridica pessoa2 = new PessoaJuridica();
            pessoa2.Email = "Empresa@email.com.br";
            pessoa2.Nome = "NomeEmpresa";
            pessoa2.Id = 2;
            pessoa2.CNPJ = "01011000/0001-12";

            lista.Add(pessoa);
            lista.Add(pessoa2);

            foreach (var item in lista)
            {
                if (item is PessoaFisica)
                {
                    Console.WriteLine($"PessoasFisicas: { ((PessoaFisica)item).Nome } -- { ((PessoaFisica)item).CPF } -- " +
                        $"{ ((PessoaFisica)item).Email } ");

                } else if(item is PessoaJuridica)
                {
                    Console.WriteLine($"PessoasJuridicas: { ((PessoaJuridica)item).Nome } -- { ((PessoaJuridica)item).CNPJ }" +
                        $"-- {((PessoaJuridica)item).Email}  ");

                }
            }
            Console.ReadKey();
        }
    }
}
