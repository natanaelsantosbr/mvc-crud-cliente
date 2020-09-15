using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natanael.Dominio
{
    public class Entidade 
    {
        public Entidade()
        {
            this.DataDoCadastro = DateTime.Now;
        }
        public int Id { get; protected set; }

        public DateTime DataDoCadastro { get; set; }
    }
}
