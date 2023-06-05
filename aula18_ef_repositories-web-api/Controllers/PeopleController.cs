using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula12_ef_test.Domain;
using aula14_ef_repositories.Data.Repositories;
using aula14_ef_repositories.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace aula14_ef_repositories.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly IPersonRepository repositiory;

        public PeopleController()
        {
            this.repositiory = new PersonRepository();
        }

        [HttpGet]
        public IEnumerable<Person>Get()
        {
            return repositiory.GetAll();
        }
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return repositiory.GetById(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Person item)
        {
            repositiory.Save(item);
            return Ok( new {
                statusCode=200,
                message = "Cadastrado com sucesso",
                item
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            repositiory.Delete(id);
            return Ok( new {
                statusCode=200,
                message = "Pessoa excluída com sucesso"
            });
        }
        [HttpPut]
        public IActionResult Put([FromBody]Person item)
        {
            repositiory.Update(item);
            return Ok( new {
                statusCode=200,
                message = item.Name + " atualizado com sucesso",
                item
            });
        }
    }
}