using Infra.EF.Repositorios;
using Natanael.Dominio.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.EF
{
    public class ServicoExternoDePersistenciaViaEntityFramework : IServicoExternoDePersistencia, IDisposable
    {
        private readonly Contexto _contexto;

        public ServicoExternoDePersistenciaViaEntityFramework(Contexto contexto)
        {
            this._contexto = contexto;
        }

        public IRepositorioDeClientes RepositorioDeClientes => new RepositorioDeClientes(_contexto);

        public void Persistir()
        {
            this._contexto.SaveChanges();
        }

        public void Dispose()
        {
            if (this._contexto != null)
                this._contexto.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}
