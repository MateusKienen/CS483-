using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces
{
    public interface ICrud<T>
    {
        void Cadastrar(T item);
        List<T> Listar();
    }
}
