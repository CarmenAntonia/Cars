using Microsoft.AspNetCore.Mvc;
using Cars.Entities;
namespace Cars.Controllers;

[Route("owners")]
[ApiController]

public class OwnersController : ControllerBase
{
    private static readonly List<Owner> OwnersList= new()
    {
        Owner.Create("Rata", "Antonia"),
        Owner.Create("Ciurescu", "Raul")
    };

    public static List<Owner> GetOwnersList()
    {
        return OwnersList;
    }
    [HttpGet(Name = "GetAllOwners")]
    public ActionResult GetOwners()
    {
        return Ok(OwnersList);
    }
    
    [HttpGet( "{Id}")]
    public ActionResult GetOwners(string id)
    {
        var owner = OwnersList.FirstOrDefault(o => o.Id == id);

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