using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natanael.Dominio.Clientes
{
    public class Cliente : Entidade
    {
        public Cliente()
        {
            this.Ativo = true;

        }
        public Cliente(string nome, string email, string cpf)
        {
            if (string.IsNullOrEmpty(nome))
                throw new InvalidOperationException("Nome obrigatório");

            if (string.IsNullOrEmpty(email))
                throw new InvalidOperationException("Email obrigatório");

            if (string.IsNullOrEmpty(cpf))
                throw new InvalidOperationException("CPF obrigatório");

            this.Nome = nome;
            this.Email = email;
            this.CPF = cpf;
        }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string CPF { get; set; }
        public bool Ativo { get; set; }
    }
}
