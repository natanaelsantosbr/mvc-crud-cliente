using Natanael.Dominio.Clientes;

namespace Natanael.Aplicacao.Clientes.Modelos
{
    public class ModeloDeClienteDaLista
    {
        public ModeloDeClienteDaLista(Cliente cliente)
        {
            if (cliente == null)
                return;

            this.Nome = cliente.Nome;
            this.Email = cliente.Email;
            this.CPF = cliente.CPF;
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
    }
}