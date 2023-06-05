using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula14_ef_repositories.Domain.Interfaces
{
    public interface IBaseRepository<Entity> where Entity : class
    {
        Entity GetById(int entityId);
        IList<Entity> GetAll();
        void Save(Entity entity);
        void Delete(int entityId);
        void Update(Entity entity);

    }
}