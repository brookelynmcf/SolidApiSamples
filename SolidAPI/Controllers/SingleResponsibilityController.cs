using Microsoft.AspNetCore.Mvc;
using SolidAPI.Resolvers;
using SolidAPI.Validators;

namespace SolidAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class SingleResponsibilityController : ControllerBase
{   SingleResponsibilityResolver _resolver;
    SingleResponsibilityValidator _validator;
    public SingleResponsibilityController(SingleResponsibilityResolver resolver,
        SingleResponsibilityValidator validator)
    {
        _resolver = resolver;
        _validator = validator;
    }
    [HttpGet(Name = "GetGreeting")]
    public string GetGreeting()
    {
        if (_validator.IsValid())
        {
            return _resolver.ResolveGreeting();
 
        }
        return "Uh oh - we shouldn't be here";
    }
}