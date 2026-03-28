using Microsoft.AspNetCore.Mvc;
using RestWithASPNET10.Models;
using RestWithASPNET10.Services;
using RestWithASPNET10.Services.Implementations;
using System.Security.Cryptography.X509Certificates;

namespace RestWithASPNET10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }


        [HttpGet]
        public IActionResult FindAll()
        {
           return Ok(_personService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult FindById(int id)
        {
            var person = _personService.FindById(id);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Person person)
        {
            var createdPerson = _personService.Create(person);
            if (createdPerson == null)
            {
                return NotFound();
            }
            return Ok(createdPerson);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Person person)
        {
            var createdPerson = _personService.Update(person);
            if (createdPerson == null)
            {
                return NotFound();
            }
            return Ok(createdPerson);
        }
            
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _personService.Delete(id);
            return NoContent();
        }
    }
}
