using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula12_ef_test.Domain;

namespace aula14_ef_repositories.Domain
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Person> People { get; set; }
    }
}