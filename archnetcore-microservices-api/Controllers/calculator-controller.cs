
using Microsoft.AspNetCore.Mvc;
namespace archnetcore_microservices_api.controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly ILogger<CalculatorController> _logger;
    public CalculatorController(ILogger<CalculatorController> logger) { _logger = logger; }

    [HttpGet("sum/{first}/{second}")]
    public IActionResult Get(string first, string second)
    {
        if (first.isNumber() && second.isNumber())
            return Ok(first.ApenasNumeros().toDecimal() + second.ApenasNumeros().toDecimal());

        return BadRequest("InvalidInput");
    }
}