using Microsoft.AspNetCore.Mvc;
using PersonWebApplicaton.Model;
using PersonWebApplicaton.Services;

namespace PersonWebApplicaton.Controllers;

public class PersonController : ControllerBase
{
    private readonly ILogger _logger;
    private IPersonService _personService;
    public PersonController(ILogger<PersonController> logger, IPersonService personService)
    {
        _logger = logger;
        _personService = personService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var people = _personService.GetAll();
        return Ok(people);
    }

    [HttpGet("{id}")]
    public IActionResult Get(long id)
    {
        var person = _personService.GetById(id);
        if (person == null)
            return NotFound();
        return Ok(person);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Person person)
    {
        if (person == null)
            return BadRequest();
        var personCreated = _personService.Create(person);
        return Ok(personCreated);
    }

    [HttpPut]
    public IActionResult Get([FromBody] Person person)
    {
        if (person == null)
            return BadRequest();
        var personCreated = _personService.Update(person);
        return Ok(personCreated);
    }

    [HttpDelete]
    public IActionResult Delete(long id)
    {
        var person = _personService.GetById(id);
        if (person == null)
            return NotFound();
        return NoContent();
    }
}
