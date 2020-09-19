using Natanael.Aplicacao.Clientes.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natanael.Aplicacao.Clientes
{
    public interface IServicoDeGestaoDeClientes
    {
        ModeloDeListaDeClientes BuscarClientesPorPaginacao(ModeloDeFiltroDeCliente filtro, int pagina);

        string Cadastrar(ModeloDeCadastroDeCliente modelo);
    }
}
