using Natanael.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.EF.Repositorios
{
    public class Repositorio<T> : IRepositorio<T> where T : Entidade
    {
        protected readonly Contexto _contexto;

        public Repositorio(Contexto contexto)
        {
            this._contexto = contexto;
        }


        public void Atualizar(int id, T novoItem)
        {
            this._contexto.Entry<T>(novoItem).State = EntityState.Modified;
        }

        public T Inserir(T item)
        {
            return this._contexto.Set<T>().Add(item);
        }

        public List<T> Listar()
        {
            return this._contexto.Set<T>().ToList();
        }

        public T BuscarPorId(int id)
        {
            return this._contexto.Set<T>().Find(id);
        }

        public T Excluir(T item)
        {
            return this._contexto.Set<T>().Remove(item);
        }
    }
}
