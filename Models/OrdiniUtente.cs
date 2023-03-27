using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
	public class OrdiniUtente
	{
        // Non richiesto dalla traccia, ma necessario
        // per le logiche.
        [System.Text.Json.Serialization.JsonIgnore]
        public long IDUtente { get; set; }
        // Tabella OrdiniProdotti
        public long IDProdottoOP { get; set; }
        public int Quantita { get; set; }
        // Tabella Prodotto
        public string NomeProdotto { get; set; }
        public int IDOrdine { get; set; }
        public List<Prodotto> Prodotti { get; set; }
    }
}

