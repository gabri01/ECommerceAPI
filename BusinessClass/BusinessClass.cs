using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Interfaces;

namespace BusinessLogic
{
    public class BusinessClass : IBusiness
    {
        IDAL dal;
        public BusinessClass(IDAL dal)
        {
            this.dal = dal;
        }

        public bool VerificaUtenteEsistente(string Email)
        {
            return dal.VerificaUtenteEsistente(Email);
        }
        public long Registrazione(Registrazione NuovoUtente)
        {
            return dal.Registrazione(NuovoUtente);
        }
        public bool AutenticazioneUtente(Utente Utente)
        {
            return dal.AutenticazioneUtente(Utente);
        }
        public string Login(Login Utente)
        {
            return dal.Login(Utente);
        }
        public bool EsisteUtente(Login Utente)
        {
            return dal.EsisteUtente(Utente);
        }
        public bool ModificaUtente(Registrazione Utente, string Nome, string Cognome, string Email)
        {
            return dal.ModificaUtente(Utente, Nome, Cognome, Email);
        }
        public List<Prodotto> GetAllProdotti()
        {
            return dal.GetAllProdotti();
        }
        public List<OrdiniUtente> GetOrdiniUtente(Utente Utente)
        {
            return dal.GetOrdiniUtente(Utente);
        }
        public bool InsertOrdine(NuovoOrdine Ordine)
        {
            return dal.InsertOrdine(Ordine);
        }
        public long InsertProdotto(Prodotto prodotto)
        {
            return dal.InsertProdotto(prodotto);
        }
    }
}