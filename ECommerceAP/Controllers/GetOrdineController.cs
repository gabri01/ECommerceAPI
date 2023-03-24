using Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace AcademyShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetOrdineController : ControllerBase
    {
        IBusiness business;

        public GetOrdineController(IBusiness business)
        {
            this.business = business;
        }
        [HttpPost]
        public IActionResult Get(Utente Utente)
        {
            if (business.AutenticazioneUtente(Utente))
                return BadRequest(new { message = "Utente non registrato." });
            return Ok(business.GetOrdiniUtente(Utente));
        }
    }
}
