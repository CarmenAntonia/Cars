namespace Cars.Entities;
using System;

public enum TipAsigurare
{
    OneMonth,
    ThreeMonths,
    SixMonths,
    OneYear
}

public class Car
{
    public string Id { get; private  set; }
    public string Brand { get; private set; }
    public string Model{ get; private set; }
    public string Color{ get; private set; }
    public int Enginecm{ get; private set; }
    public int HorsePower { get; private set; }
    public DateTime YearofProduction{ get; private set; }
    public DateTime LastItp{ get; private set; }
    public DateTime LastInsurance { get; private set; }
    public Owner Owner{ get; private set; }

    private Car()
    {
        
    }
    
    public static Car Create(string brand, string model, string color, int enginecm, int horsePower, (int year, int month, int day) yearofProduction,Owner owner)
    {
        if (string.IsNullOrWhiteSpace(brand))
            throw new Exception("Brand can't be empty");
        if (string.IsNullOrWhiteSpace(model))
            throw new Exception("Model can't be empty");
        if (string.IsNullOrWhiteSpace(color))
            throw new Exception("Color can't be empty");
        if(enginecm==0)
            throw new Exception("Enginecm can't be zero");
        if(horsePower==0)
            throw new Exception("HorsePower can't be zero");
        var manufacturingDate = new DateTime(yearofProduction.year, yearofProduction.month, yearofProduction.day);

        return new Car
        {
            Id = Guid.NewGuid().ToString(),
            Brand = brand ,
            Model = model ,
            Color = color,
            Enginecm = enginecm ,
            HorsePower = horsePower,
            YearofProduction = manufacturingDate,
            Owner = owner
        };
    }
}