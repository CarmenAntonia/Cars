using Microsoft.AspNetCore.Mvc;
using Cars.Entities;
using static Cars.Controllers.OwnersController;
using static Cars.Controllers.CarsController;
using System;
using System.Collections.Generic;
namespace Cars.Controllers;

[Route("ownerscar")]
[ApiController]

public class OwnerCarController : ControllerBase
{ 
    private readonly List<List<String>> _ownerCarList=new List<List<String>>();
    private readonly List<Owner> _owners = OwnersController.GetOwnersList();
    private readonly List<Car> _cars = CarsController.GetCarsList();
    
    [HttpGet(Name = "GetAllOwnersCars")]
    public ActionResult GetOwnersCars()
    {
        foreach (var o in _owners)
        {
            List<string> sublist = new List<string>();
            sublist.Add(o.Id);
            foreach (var c in _cars)
            {
                if (o.Id.Equals(c.Ownerid))
                {
                    sublist.Add(c.Id);
                }
            }
            _ownerCarList.Add(sublist);
        }
        return Ok(_ownerCarList);
    }
    
}