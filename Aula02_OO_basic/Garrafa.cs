namespace Aula02_OO_basic
{
    public class Garrafa
    {
        //caracteristicas
        public int Codigo{get; protected set;}
        public string Cor { get; set; }
        public int AnoFabricacao { get; protected set; }
        public string Identificacao { get; protected set; }
        public int Volume { get;}

        public int MyProperty { get; set; }



        public Garrafa(int codigo, string cor, int ano, string ident)
        {
            this.Codigo=codigo;
            this.Cor = cor;
            this.AnoFabricacao = ano;
            this.Identificacao = ident;
        }
    }
}