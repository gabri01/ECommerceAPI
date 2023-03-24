using System;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;
using Microsoft.AspNetCore.Http;

namespace ECommerceAP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrazioneController : ControllerBase
    {
        IBusiness business;

        public RegistrazioneController(IBusiness business)
        {
            this.business = business;
        }

        [HttpPost]
        public IActionResult Insert(Registrazione Utente)
        {
            if (business.VerificaUtenteEsistente(Utente.Email))
                return BadRequest(new { message = "Utente già registrato." });

            return Ok(business.Registrazione(Utente));
        }
    }
}

