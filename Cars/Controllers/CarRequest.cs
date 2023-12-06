using Cars.Entities;

namespace Cars.Controllers;

public class CarRequest
{
    public string Id { get;   set; }
    public string Brand { get;  set; }
    public string Model{ get;  set; }
    public string Color{ get;  set; }
    public int Enginecm{ get;  set; }
    public int HorsePower { get;  set; }
    public TipAsigurare TipAsigurare { get; set; }
}