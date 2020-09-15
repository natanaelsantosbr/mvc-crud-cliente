using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natanael.Dominio.Clientes
{
    public interface IRepositorioDeClientes : IRepositorio<Cliente>
    {
        List<Cliente> BuscarClientesAtivos();
    }
}
