using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula06_associacoes
{
    public abstract class Garrafa
    {
        public string CodBarras { get; protected set; }
        public string Marca { get; protected set; }
        public int Volume { get; set; }

        public Garrafa(){}

        public Garrafa(string codBarras, string marca, int volume)
        {
            this.CodBarras = codBarras;
            this.Marca = marca;
            this.Volume = volume;
        }
    }
}