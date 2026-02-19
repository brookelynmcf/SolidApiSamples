using Microsoft.AspNetCore.Mvc;
using SolidAPI.Resolvers;

namespace SolidAPI.Controllers;

[ApiController]
public class DependencyInversionController
{
    private ITellJoke tellJoke;

    DependencyInversionController(ITellJoke tellJoke)
    {
        this.tellJoke = tellJoke;
    }
    [HttpGet(Name = "DependencyInversion")]
    public void DependencyInversion()
    {
        this.tellJoke.TellJoke();
    }
}