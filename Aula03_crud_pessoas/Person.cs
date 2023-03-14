using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03_crud_pessoas
{
    public class Person
    {
        public string Nome { get; private set; }="";  
        public int Idade { get; set; }

        public Person(){}

        public Person(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public string Apresentar()
        {
            return $"Nome: {this.Nome}\nIdade {this.Idade}.";
        }
    }
}