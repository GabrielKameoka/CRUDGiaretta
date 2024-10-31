using CRUDGiaretta.Data;
using CRUDGiaretta.Models;

namespace CRUDGiaretta.Routes;

public static class PersonRoute
{
    public static void PersonRoutes(this WebApplication app)
    {
        var route = app.MapGroup("person");
        route.MapPost("", 
            async (PersonRequest req, PersonContext context) =>
            {
                var person = new PersonModel(req.name);
                await context.AddAsync(person);
                await context.SaveChangesAsync();
            });
    }
}