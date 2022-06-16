using archnetcore_microservices_api.models;
using archnetcore_microservices_api.services;
using Microsoft.AspNetCore.Mvc;
namespace archnetcore_microservices_api.controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{
    private readonly ILogger<PersonController> _logger;
    private IPersonServices _personService;
    public PersonController(ILogger<PersonController> logger, IPersonServices personServices)
    {
        _logger = logger;
        _personService = personServices;
    }

    [HttpGet]
    public IActionResult Get() { return Ok(_personService.list()); }

    [HttpGet("{id}")]
    public IActionResult Get(string id) { return Ok(_personService.getById(id)); }

    [HttpPost]
    public IActionResult Post([FromBody] Person person) { return Ok(_personService.create(person)); }

    [HttpPut]
    public IActionResult Put([FromBody] Person person) { return Ok(_personService.update(person)); }

    [HttpDelete]
    public IActionResult Delete(string id) { return Ok(_personService.delete(id)); }
}