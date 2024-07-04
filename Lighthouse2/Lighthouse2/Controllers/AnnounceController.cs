using LBPUnion.Lighthouse2.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace LBPUnion.Lighthouse2.Controllers;

[ApiController]
[GameRoute]
[Produces("text/plain")]
public class AnnounceController : ControllerBase
{
    [HttpGet("eula")]
    public IActionResult Eula() => this.Ok("eula");

    [HttpGet("announce")]
    public IActionResult Announce() => this.Ok("announce");
}