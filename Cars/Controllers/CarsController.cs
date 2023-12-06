using Microsoft.AspNetCore.Mvc;
using Cars.Entities;
namespace Cars.Controllers;

[Route("cars")]
[ApiController]
public class CarsController : ControllerBase
{
    private static readonly List<Car> CarsList= new()
    {
        Car.Create("Audi","A4","black",2000,192, (2020,10,20),"99b7a698-8ffd-43d1-9182-c29744993e5b"),
        Car.Create("Audi","A6","blue",4000,350, (2010,1,1),"4767f1a1-ccb0-441d-87bd-696fe9675297")
    };
    public static List<Car> GetCarsList()
    {
        return CarsList;
    }
    
    
    [HttpGet]
    public ActionResult<IEnumerable<Car>> GetAllCars()
    {
        return Ok(CarsList);
    }
    
    
    [HttpGet( "{Id}")]
    public ActionResult GetCarsById(string Id)
    {
        var owner = CarsList.FirstOrDefault(o => o.Id == Id);

        if (owner is null)
            return NotFound($"Student with id: {Id} does not exist");

        return Ok(owner);
    }
    
}