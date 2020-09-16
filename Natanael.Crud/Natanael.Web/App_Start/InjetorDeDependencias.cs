using Infra.EF;
using Natanael.Aplicacao.Clientes;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Natanael.Web.App_Start
{
    public class InjetorDeDependencias
    {
        public static void Injetar()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            container.Register<Contexto, Contexto>(Lifestyle.Scoped);
            container.Register<IServicoExternoDePersistencia, ServicoExternoDePersistenciaViaEntityFramework>(Lifestyle.Scoped);
            container.Register<IServicoDeGestaoDeClientes, ServicoDeGestaoDeClientes>(Lifestyle.Scoped);

            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}