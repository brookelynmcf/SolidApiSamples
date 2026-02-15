using Microsoft.AspNetCore.Mvc;
using SolidAPI.Types;

namespace SolidAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class OpenClosedController : ControllerBase
{
    [HttpGet(Name = "GetOpenClosed")]
    public Kayak GetOpenClosed()
    {
        return new Kayak();
    }
}