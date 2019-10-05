using ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    public abstract class Pessoa : EntidadeBase
    {
        public string Nome { get; set; }

        public List<Pessoa> Lista { get; set; }

        public abstract List<Pessoa> ListaPessoas();
    }
}
