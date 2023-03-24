using System;
using ECommerceAP.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Interfaces;
using DataAccessLogic;
using Models.Models;

namespace ECommerceAP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        IBusiness business;
        public LoginController(IBusiness business)
        {
            this.business = business;
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(Login Utente)
        {
            if (business.EsisteUtente(Utente))
                return Ok(business.Login(Utente));
            return BadRequest(new { message = "Utente non registrato" });
        }
    }
}
