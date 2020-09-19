using Natanael.Dominio.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natanael.Aplicacao.Clientes.Modelos
{
    public class ModeloDeListaDeClientes
    {
        public ModeloDeListaDeClientes()
        {
            this.Filtro = new ModeloDeFiltroDeCliente();
            this.Clientes = new List<ModeloDeClienteDaLista>();
        }

        public ModeloDeListaDeClientes(List<Cliente> clientes, int totalDeRegistros, ModeloDeFiltroDeCliente filtro) : this()
        {
            if (filtro != null)
                this.Filtro = filtro;

            this.TotalDeRegistros = totalDeRegistros;

            clientes.ToList().ForEach(a => this.Clientes.Add(new ModeloDeClienteDaLista(a)));

        }

        public ModeloDeFiltroDeCliente Filtro{ get; set; }

        public List<ModeloDeClienteDaLista> Clientes { get; set; }

        public int TotalDeRegistros { get; set; }

    }
}
