using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetopoo.Models
{
    public class Juridica
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int Cnpj { get; private set; }
        public Juridica(string nome, int idade, string login, string senha, int cnpj)
        {
            Nome = nome;
            Idade = idade;
            Login = login;
            Senha = senha;
            Cnpj = cnpj;
        }
    }
}
