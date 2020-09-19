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

        public ServicoDeGestaoDeClientes(IServicoExternoDePersistencia servicoExternoDePersistencia)
        {
            this._servicoExternoDePersistencia = servicoExternoDePersistencia;
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
