using Natanael.Dominio.Clientes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.EF.Mapeamentos
{
    internal class MapeamentoDeCliente : EntityTypeConfiguration<Cliente>
    {
        public MapeamentoDeCliente()
        {
            this.ToTable("Clientes");

            this.Property(a => a.Nome).IsRequired().HasMaxLength(255);
            this.Property(a => a.Email).IsRequired().HasMaxLength(255);
            this.Property(a => a.CPF).IsRequired().HasMaxLength(11);
            this.Property(a => a.Ativo).IsRequired();
        }
    }
}
