using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    public class PessoaJuridica : Pessoa
    {

        public string CNPJ { get; set; }
        public string NomeFantasia { get; set; }
        List<PessoaJuridica> ListaPj { get; set; }

        

        public void Cadastrar(PessoaJuridica item)
        {
            ListaPj.Add(item);
        }

        public List<PessoaJuridica> Listar()
        {
            return ListaPj;
        }
    }
}
