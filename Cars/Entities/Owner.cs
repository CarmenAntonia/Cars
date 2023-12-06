using Microsoft.AspNetCore.Http.HttpResults;
namespace Cars.Entities;

public class Owner
{
    public string Id { get; private  set; }
    public string FirstName { get; private set; }
    public string LastName{ get; private set; }
    public int Experience{ get; private set; }
    public List<Car> Cars { get; set; }

    private Owner()
    {
    }
    
    public static Owner Create(string firstName, string lastName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            throw new Exception("First Name can't be empty");
        
        if (string.IsNullOrWhiteSpace(lastName))
            throw new Exception("Last Name can't be empty");

        return new Owner
        {
            Id = Guid.NewGuid().ToString(),
            FirstName = firstName,
            LastName = lastName
        };
    }

    public void SetFirstName(string firstName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            throw new Exception("First Name can't be empty");

        firstName = firstName.Replace(" ", "");

        FirstName = firstName;
    }

    public void SetLastName(string lastName)
    {
        if (string.IsNullOrWhiteSpace(lastName))
            throw new Exception("Last Name can't be empty");

        LastName = lastName;
    }

}