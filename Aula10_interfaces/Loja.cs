using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula10_interfaces
{
    public class Loja
    {
        private List<IItemEstoque> _itensEmEstoque;

        public Loja(List<IItemEstoque>itemEstoque)
        {
            _itensEmEstoque = itemEstoque;
        }

        public void AdicionarItem(IItemEstoque item) //problema de acoplamento aqui por que?
        {
            _itensEmEstoque.Add(item);
        }

       
    }
}