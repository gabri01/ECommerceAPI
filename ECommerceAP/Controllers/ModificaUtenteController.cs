using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Update.Internal;
using Models;
using Interfaces;

namespace ECommerceAP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModificaUtenteController : ControllerBase
	{
        IBusiness business;

        public ModificaUtenteController(IBusiness business)
        {
            this.business = business;
        }

        [HttpPost]
        public IActionResult Update(Registrazione Utente, string Nome, string Cognome, string Email)
        {
            //if (business.AutenticazioneUtente(Utente))
            //    return BadRequest(new { message = "Utente non registrato." });

            if (business.ModificaUtente(Utente, Nome, Cognome, Email))
                return Ok(new { message = "Aggiornamento effettuato con successo." });
            
            return Ok(business.ModificaUtente(Utente, Nome, Cognome, Email));
        }
    }
}