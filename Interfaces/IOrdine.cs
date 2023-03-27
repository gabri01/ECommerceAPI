using System;
using Models;

namespace Interfaces
{
	public interface IOrdine
	{
        //GetAllOrdini
        public List<OrdiniUtente> GetOrdiniUtente(Utente Utente);
        bool InsertOrdine(NuovoOrdine ordine);
    }
}

