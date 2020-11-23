using DAL.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private FilmService _service;

        public FilmController()
        {
            _service = new FilmService();
        }

        [HttpGet]
        public IActionResult GetAll() {
            return Ok(_service.GetAll());
        }

        [HttpGet]
        [Route("Actor")]
        public IActionResult GetByActor(int id) {
            return Ok(_service.GetByActor(id));
        }

        [HttpGet]
        [Route("Category")]
        public IActionResult GetByCategory(int id)
        {
            return Ok(_service.GetByCategory(id));
        }

        [HttpGet]
        [Route("Title")]
        public IActionResult GetByTitle(string title)
        {
            return Ok(_service.GetByTitle(title));
        }

        [HttpGet]
        [Route("Language")]
        public IActionResult GetByLanguage(int id)
        {
            return Ok(_service.GetByLanguage(id));
        }

        [HttpGet]
        [Route("KeyWord")]
        public IActionResult GetByKeyWord(string keyword)
        {
            return Ok(_service.GetByKeyWord(keyword));
        }
    }
}
