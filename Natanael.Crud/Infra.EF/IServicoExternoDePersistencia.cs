using Natanael.Dominio.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.EF
{
    public interface IServicoExternoDePersistencia
    {
        void Persistir();

        IRepositorioDeClientes RepositorioDeClientes { get; }
    }
}
