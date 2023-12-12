using Cars.DataBase;
using Microsoft.AspNetCore.Mvc;
using Cars.Entities;
namespace Cars.Controllers;

[Route("owners")]
[ApiController]

public class OwnersController : ControllerBase
{
    private readonly AppDbContext _context;

    public OwnersController(AppDbContext context)
    {
        _context = context;
    }
    [HttpGet(Name = "GetAllOwners")]
    public ActionResult GetOwners()
    {
        return Ok(_context.Cars.ToList());
    }
    
    [HttpGet( "{Id}")]
    public ActionResult GetOwners(string id)
    {
        var owner = _context.Cars.FirstOrDefault(o => o.Id == id);

        if (owner is null)
            return NotFound($"Owner with id: {id} does not exist");

        return Ok(owner);
    }

    [HttpPost]
    public ActionResult Post([FromBody]CarRequest car)
    {
        
        
        return Ok(car);
    }

}