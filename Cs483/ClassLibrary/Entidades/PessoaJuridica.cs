using ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    class PessoaJuridica : Pessoa, ICrud<PessoaJuridica>
    {
        
        public string CNPJ { get; set; }
   
        public void Cadastrar(PessoaJuridica item)
        {
                        
        }

        public List<PessoaJuridica> Listar()
        {
          
        }
    }
}
