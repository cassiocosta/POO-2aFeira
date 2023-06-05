using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula12_ef_test.Data;
using aula12_ef_test.Domain;
using aula14_ef_repositories.Domain.Interfaces;

namespace aula14_ef_repositories.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DataContext context;

        public PersonRepository()
        {
            this.context = new DataContext();
        }

        public void Delete(int entityId)
        {
            var p = GetById(entityId);
            context.People.Remove(p);
            context.SaveChanges();
        }

        public IList<Person> GetAll()
        {
            return context.People.ToList();
        }

        public Person GetById(int entityId)
        {
            return context.People.SingleOrDefault(x=>x.Id == entityId);
        }

        public void Save(Person entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(Person entity)
        {
            context.People.Update(entity);
            context.SaveChanges();
        }
    }
}