// See https://aka.ms/new-console-template for more information
using aula12_ef_test.Data;
using aula12_ef_test.Domain;
using aula14_ef_repositories.Data.Repositories;
using aula14_ef_repositories.Domain;
using aula14_ef_repositories.Domain.Interfaces;

var db = new DataContext();

// Create


IPersonRepository _personRepository = new PersonRepository(db);

//GetAllPeople();

// Console.WriteLine("Inserting a person using GetById");
// var p = _personRepository.GetById(12);

// Console.WriteLine($"Id: {p.Id} | Nome: {p.Name} | Fone: {p.phoneNumber}");

//Console.WriteLine("Deleting a person");
//_personRepository.Delete(10);

//GetAllPeople();

// Console.WriteLine("update a  person");

var p = _personRepository.GetById(1);
p.City  = new City { Id= 3 };
p.Name = "Joao da Silva update cidade";
p.phoneNumber = "55998877665544";
_personRepository.Update(p);

// Console.WriteLine("-----obj alterado---------");
// GetAllPeople();

// var existsCity = new City { Id= 2 };

// Console.WriteLine("Inserting a new person");
// var person = new Person() 
//     {   Name = "Sheila", 
//         phoneNumber ="3455666",
//         City = existsCity
//     };

// _personRepository.Save(person);
GetAllPeople();

void GetAllPeople()
{
    Console.WriteLine("Show people");
    var people = _personRepository.GetAll();
    foreach (var item in people)
    {
        //if ternário????
        // condição ? true : false
        var city = item.City == null ? "Sem Cidade" : item.City.Name;
        Console.WriteLine($"Id: {item.Id} | Nome: {item.Name} | Fone: {item.phoneNumber} | Cidade: { city }");
    }
}