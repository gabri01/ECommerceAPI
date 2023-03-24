using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Interfaces
{
	public interface IBusiness
	{		
        public bool VerificaUtenteEsistente(string Email);
        public bool AutenticazioneUtente(Utente Utente);
        public string Login(Login Utente);
        public bool EsisteUtente(Login Utente);
        public long Registrazione(Registrazione NuovoUtente);
        public bool ModificaUtente(Registrazione Utente, string Nome, string Cognome, string Email);
        public List<Prodotto> GetAllProdotti();
        public List<OrdiniUtente> GetOrdiniUtente(Utente Utente);
    }	
}

