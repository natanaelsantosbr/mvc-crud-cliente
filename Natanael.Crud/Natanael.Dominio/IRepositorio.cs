using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natanael.Dominio
{
    public interface IRepositorio<T> where T : Entidade
    {
        T Inserir(T item);
        void Atualizar(int id, T novoItem);
        T BuscarPorId(int id);
        List<T> Listar();
        T Excluir(T item);
    }
}
