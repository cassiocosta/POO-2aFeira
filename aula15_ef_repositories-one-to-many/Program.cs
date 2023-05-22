// See https://aka.ms/new-console-template for more information
using aula12_ef_test.Data;
using aula12_ef_test.Domain;
using aula14_ef_repositories.Data.Repositories;
using aula14_ef_repositories.Domain.Interfaces;

var db = new DataContext();

// Create
//Console.WriteLine("Inserting a new person");
//var person = new Person() { Name = "Gustavo 1", phoneNumber ="5551889988998" };

IPersonRepository _personRepository = new PersonRepository(db);
//_personRepository.Save(person);



GetAllPeople();

Console.WriteLine("Inserting a person using GetById");
var p = _personRepository.GetById(12);

Console.WriteLine($"Id: {p.Id} | Nome: {p.Name} | Fone: {p.phoneNumber}");

//Console.WriteLine("Deleting a person");
//_personRepository.Delete(10);

//GetAllPeople();

Console.WriteLine("update a  person");
p.Name = "Gustavo Teste update";
p.phoneNumber = "55998877665544";
_personRepository.Update(p);

Console.WriteLine("-----obj alterado---------");
GetAllPeople();

void GetAllPeople()
{
    Console.WriteLine("Show people");
    var people = _personRepository.GetAll();
    foreach (var item in people)
    {
        Console.WriteLine($"Id: {item.Id} | Nome: {item.Name} | Fone: {item.phoneNumber}");
    }
}