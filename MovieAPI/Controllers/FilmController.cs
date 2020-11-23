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
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet]
        [Route("Actor")]
        public IActionResult GetByActor(string actor)
        {
            return Ok(_service.GetByActor(actor));
        }

        [HttpGet]
        [Route("Category")]
        public IActionResult GetBycategory(string category)
        {
            return Ok(_service.GetByActor(category));
        }

        [HttpGet]
        [Route("Language")]
        public IActionResult GetByLanguage(string language)
        {
            return Ok(_service.GetByLanguage(language));
        }

        [HttpGet]
        [Route("KeyWord")]
        public IActionResult GetByKeyWord(string keyword)
        {
            return Ok(_service.GetByKeyWord(keyword));
        }

    }
}
