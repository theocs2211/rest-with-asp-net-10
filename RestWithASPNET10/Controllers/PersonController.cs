using Microsoft.AspNetCore.Mvc;
using RestWithASPNET10.Models;
using RestWithASPNET10.Services;
using RestWithASPNET10.Services.Implementations;
using System.Security.Cryptography.X509Certificates;

namespace RestWithASPNET10.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private IPersonService _personService;
        private readonly ILogger<PersonController> _logger;

        public PersonController(IPersonService personService, ILogger<PersonController> logger)
        {
            _personService = personService;
            _logger = logger;
        }


        [HttpGet]
        public IActionResult FindAll()
        {
            _logger.LogInformation("Fetching all persons");
            return Ok(_personService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult FindById(int id)
        {
            _logger.LogInformation($"Fetching person with id {id}");
            var person = _personService.FindById(id);
            if (person == null)
            {
                _logger.LogWarning($"Person with ID {id} not found");
                return NotFound();
            }
            _logger.LogInformation($"person with id {id} found");
            return Ok(person);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Person person)
        {
            _logger.LogInformation($"Creating new person: {person.FirstName}");
            var createdPerson = _personService.Create(person);
            if (createdPerson == null)
            {
                _logger.LogError($"Failed to create person with name {person.FirstName}");
                return NotFound();
            }
            _logger.LogInformation($"Person with name {person.FirstName} Created Successfully");
            return Ok(createdPerson);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Person person)
        {
            _logger.LogInformation($"Updating person with id {person.Id}");
            var createdPerson = _personService.Update(person);
            if (createdPerson == null)
            {
                _logger.LogError($"Failed to update person with ID {person.Id}");
                return NotFound();
            }
            _logger.LogInformation($"Person with id {person.Id} Updated successfully");
            return Ok(createdPerson);
        }
            
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _logger.LogInformation($"Deleting person with id {id}");
            _personService.Delete(id);
            _logger.LogInformation($"Person with id {id} Deleted successfully");
            return NoContent();
        }
    }
}
