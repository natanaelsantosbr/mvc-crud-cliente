using Natanael.Dominio.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.EF.Repositorios
{
    public class RepositorioDeClientes : Repositorio<Cliente>, IRepositorioDeClientes
    {
        public RepositorioDeClientes(Contexto contexto) : base(contexto)
        {

        }

        public List<Cliente> BuscarClientesAtivos()
        {
            var query = this._contexto.Set<Cliente>().AsQueryable();

            query.Where(a => a.Ativo);

            return query.ToList();
        }
    }
}
