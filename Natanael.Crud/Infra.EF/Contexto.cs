using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infra.EF
{
    public class Contexto : DbContext
    {
        public Contexto() : base(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Contexto, Servicos.Migrations.Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.Configuration.LazyLoadingEnabled = false;
            base.Configuration.ProxyCreationEnabled = false;

            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();



            base.OnModelCreating(modelBuilder);
        }
    }
}
