using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula10_interfaces.Exercicio_01
{
    public class Cachorro : IAnimal
    {
        public string EmitirSom()
        {
            return "uauau";
        }
    }
}