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
    public class ActorController : ControllerBase
    {
        private ActorService _service;

        [HttpGet]
        public IActionResult getAll() {
            return Ok(_service.GetAll());
        }
        [HttpGet("{id:int}")]
        public IActionResult getById(int id) {
            return Ok(_service.GetById(id));
        }
        [HttpGet]
        [Route("title")]
        public IActionResult getByFilm(string title) {
            return Ok(_service.GetByFilm(title));
        }
        [HttpGet]
        [Route("initial")]
        public IActionResult getActorByInitial(string initial) {
            return Ok(_service.GetByInitial(initial[0], initial[1]));
        }
        [HttpGet]
        [Route("AllInitials")]
        public IActionResult getAllByInitial() {
            return Ok(_service.GetAllInitials());
        }
        public ActorController()
        {
            _service = new ActorService();
        }
    }
}
