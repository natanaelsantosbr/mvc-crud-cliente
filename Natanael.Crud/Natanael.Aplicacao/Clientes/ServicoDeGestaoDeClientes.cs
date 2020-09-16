using Infra.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natanael.Aplicacao.Clientes
{
    public class ServicoDeGestaoDeClientes : IServicoDeGestaoDeClientes
    {
        private IServicoExternoDePersistencia _servicoExternoDePersistencia;

        public ServicoDeGestaoDeClientes(IServicoExternoDePersistencia servicoExternoDePersistencia)
        {
            this._servicoExternoDePersistencia = servicoExternoDePersistencia;
        }

        public void Processar()
        {
            var listar = this._servicoExternoDePersistencia.RepositorioDeClientes.Listar();

            if(listar != null)
            {

            }
        }
    }
}
