using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using LorryModels;

namespace LorryMobileAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PickupsController : ControllerBase
    {
        public PickupsController()
        {
        }

        // GET: api/Pickups
        [HttpGet]
        public ActionResult<IEnumerable<Pickup>> GetPickup()
        {
            List<Pickup> pickups = new List<Pickup>();
            pickups.Add(new Pickup(1, "1607 Pennsylvania Ave", "", true, DateTime.Now, DateTime.Parse("1899-12-31"), "0770770897"));
            pickups.Add(new Pickup(2, "Munster''s Mansion", "", true, DateTime.Now, DateTime.Parse("1899-12-31"), "465484451"));
            pickups.Add(new Pickup(3, "Azure Container Registry", "Azure App Service", true, DateTime.Now, DateTime.Parse("1899-12-31"), "Barcode"));
            return pickups;
        }

        // GET: api/Pickups/5
        [HttpGet("getid/{id}")]
        public ActionResult<Pickup> GetPickup(int id)
        {
            var pickup = new Pickup(3, "From Docker Hub", "Azure App Service", true, DateTime.Now, DateTime.Parse("1899-12-31"), "Barcode");

            return pickup;
        }
    }
}
