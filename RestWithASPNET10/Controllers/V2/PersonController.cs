using Microsoft.AspNetCore.Mvc;
using RestWithASPNET10.Data.DTO.V2;
using RestWithASPNET10.Services.Implementations;

namespace RestWithASPNET10.Controllers.V2
{
    [Route("api/[controller]/v2")]
    [ApiController]

    public class PersonController : ControllerBase
    {
        private PersonServiceImplV2 _personService;
        private readonly ILogger<PersonController> _logger;

        public PersonController(PersonServiceImplV2 personService, ILogger<PersonController> logger)
        {
            _personService = personService;
            _logger = logger;
        }


        [HttpPost]
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
            return Ok(createdPerson);
        }
    }
}
