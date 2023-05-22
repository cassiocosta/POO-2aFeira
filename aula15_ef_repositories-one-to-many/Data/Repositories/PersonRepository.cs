using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula12_ef_test.Data;
using aula12_ef_test.Domain;
using aula14_ef_repositories.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace aula14_ef_repositories.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DataContext context;

        public PersonRepository(DataContext context)
        {
            this.context = context;
        }

        public void Delete(int entityId)
        {
            var p = GetById(entityId);
            context.People.Remove(p);
            context.SaveChanges();
        }

        public IList<Person> GetAll()
        {
            return context.People.Include(x=>x.City).ToList();
        
        }

        public Person GetById(int entityId)
        {
            return context.People.Include(x=>x.City).SingleOrDefault(x=>x.Id == entityId);
        }

        public void Save(Person entity)
        {
            entity.City = context.Cities.Find(entity.City.Id);
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(Person entity)
        {
            entity.City = context.Cities.SingleOrDefault(x=>x.Id == entity.City.Id);

            context.People.Update(entity);
            context.SaveChanges();
        }
    }
}