using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula14_ef_repositories.Domain;

namespace aula12_ef_test.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string phoneNumber { get; set; }
        public City City { get; set; }
    }
}