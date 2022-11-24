using HelpDebugGov.Db;
using Microsoft.AspNetCore.Mvc;

namespace HelpDebugGov.Controllers;


[Route("api/[controller]")]
[ApiController]
public class UserController : Controller
{
    private readonly ILogger<UserController> _logger;
    private readonly PostgreSqlDBContext _dbContext;

    public UserController(PostgreSqlDBContext context, ILogger<UserController> logger)
    {
        _logger = logger;
        _dbContext = context;
    }

    [HttpGet]
    public async Task<ActionResult<String>> Get()
    {
        return Ok(await Task.FromResult("Hello World"));
    }
}