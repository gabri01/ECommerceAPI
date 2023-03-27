using Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace AcademyShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NuovoOrdineController : ControllerBase
    {
        IBusiness business;

        public NuovoOrdineController(IBusiness business)
        {
            this.business = business;
        }
        [HttpPost]
        public IActionResult Insert(NuovoOrdine Ordine)
        {
            Utente Utente = new Utente()
            {
                ID = Ordine.IDUtente,
                Email = Ordine.Email,
                Password = Ordine.Password
            };
            if (business.AutenticazioneUtente(Utente))
                return BadRequest(new { message = "Utente non registrato." });
            if (business.InsertOrdine(Ordine))
                return Ok("Oridine effettuato.");
            return BadRequest(new { message = "Ordine non effettuato!" });
        }
    }
}
