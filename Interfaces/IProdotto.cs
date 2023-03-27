using System;
using Models;

namespace Interfaces
{
	public interface IProdotto
	{
        public List<Prodotto> GetAllProdotti();
        public long InsertProdotto(Prodotto prodotto);
    }
}

