using Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetProdottiController : ControllerBase
    {
        IBusiness business;
        public GetProdottiController(IBusiness business)
        {
            this.business = business;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(business.GetAllProdotti());
        }
    }
}

