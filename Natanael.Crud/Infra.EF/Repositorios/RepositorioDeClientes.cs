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

        public List<Cliente> BuscarClientesPorPaginacao(string nome, string email, string cpf, int pagina, int registrosPorPagina, out int totalDeRegistros)
        {
            var query = base._contexto.Set<Cliente>().AsQueryable();

            if (!string.IsNullOrEmpty(nome))
                query = query.Where(a => a.Nome.Contains(nome));

            if (!string.IsNullOrEmpty(email))
                query = query.Where(a => a.Email.Contains(email));

            if (!string.IsNullOrEmpty(cpf))
                query = query.Where(a => a.CPF.Contains(cpf));

            totalDeRegistros = query.Count();

            return query.OrderByDescending(a => a.Id).Skip((pagina - 1) * registrosPorPagina)
                .Take(registrosPorPagina).ToList();
        }
    }
}
