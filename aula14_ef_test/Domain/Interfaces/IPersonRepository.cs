using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula12_ef_test.Domain;

namespace aula14_ef_repositories.Domain.Interfaces
{
    public interface IPersonRepository : IBaseRepository<Person>
    {
        
    }
}