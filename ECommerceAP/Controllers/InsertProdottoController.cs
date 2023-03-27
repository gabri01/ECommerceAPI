using System;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ECommerceAP.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class InsertProdottoController
    {
            IBusiness business;

            public InsertProdottoController(IBusiness business)
            {
                this.business = business;
            }

            [HttpPost]
        public long InsertProdotto(Prodotto prodotto)
        {
            return (business.InsertProdotto(prodotto));
        }
    }
}

