using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula10_interfaces.Exercicio_01
{
    public class Papagaio : IAnimal
    {
        public string EmitirSom()
        {
            return "vamo vamo tricoloooorr hoje eu vim...  ";
        }
    }
}