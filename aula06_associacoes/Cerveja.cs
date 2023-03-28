using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula06_associacoes
{
    
    public class Cerveja : Garrafa
    {
        public int TeorAlcolico { get; private set; }

        public Cerveja(string codBarras, string marca, int volume, int teorAlcolico) 
        {
            base.CodBarras = codBarras;
            this.TeorAlcolico = teorAlcolico;

        }

        
    }
}