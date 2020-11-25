using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieDAL.Models;
using MovieDAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovielRental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : ControllerBase
    {

        private RentalService _service;
        
        public RentalController()
        {
            _service = new RentalService();
        }
        [HttpPost]
        public IActionResult Pute(Rental rent, Film fi)
        {
            return _service.Insert(rent, fi);
        }
    }
}
