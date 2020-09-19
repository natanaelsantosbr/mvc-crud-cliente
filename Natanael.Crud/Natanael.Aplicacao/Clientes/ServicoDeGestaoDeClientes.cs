using Infra.EF;
using Natanael.Aplicacao.Clientes.Modelos;
using Natanael.Dominio.Clientes;
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

        private readonly int _registrosPorPagina = 30;
        public ServicoDeGestaoDeClientes(IServicoExternoDePersistencia servicoExternoDePersistencia)
        {
            this._servicoExternoDePersistencia = servicoExternoDePersistencia;
        }

        public ModeloDeListaDeClientes BuscarClientesPorPaginacao(ModeloDeFiltroDeCliente filtro, int pagina)
        {
            var clientes = this._servicoExternoDePersistencia
                .RepositorioDeClientes
                .BuscarClientesPorPaginacao(filtro.Nome, filtro.Email, filtro.CPF, pagina, _registrosPorPagina, out int totalDeRegistros);

            return new ModeloDeListaDeClientes(clientes, totalDeRegistros, filtro);
        }

        public string Cadastrar(ModeloDeCadastroDeCliente modelo)
        {
            var cliente = new Cliente(modelo.Nome, modelo.Email, modelo.CPF);

            this._servicoExternoDePersistencia.RepositorioDeClientes.Inserir(cliente);

            this._servicoExternoDePersistencia.Persistir();

            return "Cliente cadastrado com sucesso";
        }
    }
}
