using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetopoo.Models
{
    internal class AreaProfissional
    {
        public string Nome { get; set; }
        public string Profissao { get; set; }
        public AreaProfissional(string nome, string profissao)
        {
            Nome = nome;
            Profissao = profissao;
        }
    }
}
