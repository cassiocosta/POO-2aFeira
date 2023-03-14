using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03_crud_pessoas
{
    public class PersonRepository
    {
        public static List<Person> pessoasMaster = new List<Person>();
        public void Adicionar(Person pessoa)
        {
            pessoasMaster.Add(pessoa);
        }
    }
}