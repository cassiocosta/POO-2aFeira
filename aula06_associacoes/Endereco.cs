using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula06_associacoes
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public Pessoa Pessoa { get; set; }

        public Endereco(int id, string Logradouro)
        {
            this.Id = id;
            this.Logradouro = Logradouro;
        }

    }
}