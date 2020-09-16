using Natanael.Dominio.Clientes;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.EF.Servicos.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Contexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            MigrationsDirectory = @"Servicos/Migrations";
        }

        protected override void Seed(Contexto contexto)
        {
            var clientes = new List<Cliente>
            {
                new Cliente("Natanael", "natanaelsantosbr@gmail.com","03753828106")
            };

            foreach (var cliente in clientes)
            {
                var encontrou = contexto.Set<Cliente>().FirstOrDefault(a => a.CPF == cliente.CPF);

                if(encontrou == null)
                {
                    contexto.Set<Cliente>().Add(cliente);
                    contexto.SaveChanges();
                }

            }

            base.Seed(contexto);
        }
    }
}
