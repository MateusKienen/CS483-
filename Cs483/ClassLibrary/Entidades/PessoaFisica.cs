﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    public class PessoaFisica : Pessoa
    {

        public string CPF { get; set; }


        public void Cadastrar(PessoaFisica item)
        {
            //ListaPf.Add(item);
        }

    }
}
