using Microsoft.AspNetCore.Mvc;
using RestWithASPNET10.Data.DTO.V1;
using RestWithASPNET10.Services;

namespace RestWithASPNET10.Controllers.V1
{
    [Route("api/[controller]/v1")]
    [ApiController]

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
        [ProducesResponseType(200, Type = typeof(List<PersonDTO>))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult FindAll()
        {
            _logger.LogInformation("Fetching all persons");
            return Ok(_personService.FindAll());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(PersonDTO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
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
        [ProducesResponseType(200, Type = typeof(PersonDTO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Create([FromBody] PersonDTO person)
        {
            _logger.LogInformation($"Creating new person: {person.FirstName}");
            var createdPerson = _personService.Create(person);
            if (createdPerson == null)
            {
                _logger.LogError($"Failed to create person with name {person.FirstName}");
                return NotFound();
            }
            _logger.LogInformation($"Person with name {person.FirstName} Created Successfully");
            Response.Headers.Append("X-API-Deprecated", "true");
            Response.Headers.Append("X-API-Deprecation-Date", "2026-12-31");
            return Ok(createdPerson);
        }

        [HttpPut]
        [ProducesResponseType(200, Type = typeof(PersonDTO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Update([FromBody] PersonDTO person)
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
        [ProducesResponseType(204)]
        public IActionResult Delete(long id)
        {
            _logger.LogInformation($"Deleting person with id {id}");
            _personService.Delete(id);
            _logger.LogInformation($"Person with id {id} Deleted successfully");
            return NoContent();
        }
    }
}
