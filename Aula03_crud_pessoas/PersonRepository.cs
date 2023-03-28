using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03_crud_pessoas
{
    public class PersonRepository
    {
        public static List<Person> people = new List<Person>();
        public void Adicionar(Person pessoa)
        {
            people.Add(pessoa);
        }

        public List<Person>GetlAll()
        {
            return people;
        }

        public Person GetlAll(string nome)
        {
            return people.Find(x=>x.Nome==nome);
        }

        public Person GetByIdForEachDefault(int id)
        {
            Person obj = null;
           foreach (var item in people)
           {
                 if(item.Id == id)
                     obj = item;
           }
            return obj;
        }
        public Person GetByIdForDefault(int id)
        {
            Person obj = null;
            for (int i = 0; i < people.Count; i++)
            {
                if(people[i].Id == id)
                    obj = people[i];
            }
            return obj;
        }

        public Person GetByIdLambda(int id)
        {
            return people.Find(obj=>obj.Id == id);
        }
        public List<Person> GetByNome(string pedaco)
        {
            return people.FindAll(obj=>obj.Nome.Contains(pedaco));
        }
    }
}