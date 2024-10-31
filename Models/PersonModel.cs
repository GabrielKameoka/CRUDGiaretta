using CRUDGiaretta.Routes;

namespace CRUDGiaretta.Models;

public class PersonModel
{
    public PersonModel(string name)
    {
        Name = name;
        Id = Guid.NewGuid();
    }
    
    public Guid Id { get; init; }//poderá ser alterada apenas uma única vez
    public string Name { get; private set; }

    
}