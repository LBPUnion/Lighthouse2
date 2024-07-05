using LBPUnion.Lighthouse2.Types;
using Microsoft.AspNetCore.Mvc;

namespace LBPUnion.Lighthouse2.Controllers;

[Produces("text/plain")]
public class AnnounceController : GameController
{
    [HttpGet("eula")]
    public IActionResult Eula() => this.Ok("eula");

    [HttpGet("announce")]
    public IActionResult Announce() => this.Ok("announce");
}