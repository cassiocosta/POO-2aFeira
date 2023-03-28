using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03_crud_pessoas
{
    public class Person
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public City City { get; set; }

        public Person(){}

        public Person(string nome, int idade, City city)
        {
            this.Nome = nome;
            this.Idade = idade;
            City = city;
        }

        public string Apresentar()
        {
            return $"Nome: {this.Nome}\nIdade {this.Idade}.";
        }
    }
}