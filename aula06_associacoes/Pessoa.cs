using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula06_associacoes
{
    public class Pessoa
    {
        public int Id { get; set; } 
        public string Nome { get; set; }
        public List<Endereco> enderecos;


        public void AddEndereco(Endereco endereco)
        {
            enderecos.Add(endereco);
        }
    }
}