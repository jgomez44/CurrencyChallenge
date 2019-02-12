using Calculator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Calculator.Controllers
{
    public class BananaController : ApiController
    {
        BananaService bananaService = new BananaService();

        [Route("api/bananas/{startDate:datetime}/{numberOfDays:int}"), HttpGet]
        public string BananaPrice(DateTime startDate, int numberOfDays)
        {
            return bananaService.BananaPrice(startDate, numberOfDays);
        }
    }
}