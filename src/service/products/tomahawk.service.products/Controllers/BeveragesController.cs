using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tomahawk.domain.products;
using tomahawk.domain.products.Enums;

namespace tomahawk.service.products.Controllers
{
    public class BeveragesController : Controller
    {
        [HttpGet]
        [Route("beverages")]
        public IActionResult GetBeverages()
        {
            IEnumerable<Beverage> beverages = new Beverage[] 
            {
                new Beverage { Id = Guid.NewGuid(), Name = "Coca Cola", Capacity = 600, Presentation = BeveragePresentation.Can, Type = BeverageType.Soda },
                new Beverage { Id = Guid.NewGuid(), Name = "Water", Capacity = 500, Presentation = BeveragePresentation.Bottle, Type = BeverageType.Water }
            };
            return Ok(beverages);
        }
    }
}