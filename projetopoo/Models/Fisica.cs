using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetopoo.Models
{
    public class Fisica
    {
        public Guid? FisicaID { get; private set; }
        public string Nome { get; private set; }
        public int Idade { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int Cpf { get; private set; }
       // public DateTime DataDeNascimento { get; set; }
        public Fisica(string nome, int idade, string login, string senha, int cpf, Guid? fisicaID = null)
        {
            FisicaID = fisicaID == null ? Guid.NewGuid() : fisicaID;
            Nome = nome;
            Idade = idade;
            Login = login;
            Senha = senha;
            Cpf = cpf;
           // DataDeNascimento = dataDeNascimento;
        }
    }
}
