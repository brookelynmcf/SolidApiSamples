using Microsoft.AspNetCore.Mvc;
using SolidAPI.Types;

namespace SolidAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class LinskovSubController
{
    [HttpGet(Name = "GetLinskovSub")]
    public string Get()
    {
        SailBoat boat = new SailBoat();
        return boat.GetWindPower();
    }
}