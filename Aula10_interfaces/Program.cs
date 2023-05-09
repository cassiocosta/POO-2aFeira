// See https://aka.ms/new-console-template for more information
using Aula10_interfaces;
using Aula10_interfaces.Exercicio_01;

Console.WriteLine("Hello, World!");




// Exemplo de uso
var loja = new Loja(new List<IItemEstoque>);
var roupa = new Roupa();
loja.AdicionarItem(roupa);

var calcado = new Calcado();
loja.AdicionarItem(calcado);

var brinquedo = new Brinquedo();
loja.AdicionarItem(brinquedo);

IItemEstoque brinquedo2 = new Brinquedo();


var cachorro = new Cachorro();
Console.WriteLine(cachorro.EmitirSom());
