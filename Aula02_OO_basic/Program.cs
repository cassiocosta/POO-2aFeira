// See https://aka.ms/new-console-template for more information
using Aula02_OO_basic;

//instanciar um objeto

Garrafa garrafaDoCassio = new Garrafa(1234,"cinza",2000,"garrafa mais bonita");


Console.WriteLine(garrafaDoCassio.AnoFabricacao + " " + garrafaDoCassio.Cor);
garrafaDoCassio.Cor = "tricolor";

Console.WriteLine(garrafaDoCassio.AnoFabricacao + " " + garrafaDoCassio.Cor);

Garrafa garrafaDoFelipe = new Garrafa(5555,"azul",2021,"teste do felipe");
Console.WriteLine(garrafaDoFelipe.AnoFabricacao);


// Console.WriteLine("digite um número inteiro:");
// var retorno = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("voce digitou " + retorno);


var obj = new Calculadora();
var result = obj.Calcular(12,20,"somar");

show("a soma é " + result);


void show(string msg)
{
    Console.WriteLine(msg);

}

