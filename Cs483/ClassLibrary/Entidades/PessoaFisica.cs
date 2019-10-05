using ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    class PessoaFisica : Pessoa, ICrud<PessoaFisica>
    {

        public string CPF { get; set; }

        public void Cadastrar(PessoaFisica item)
        {

        }

        public List<PessoaFisica> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
