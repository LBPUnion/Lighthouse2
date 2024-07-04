using LBPUnion.Lighthouse2.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace LBPUnion.Lighthouse2.Controllers;

[ApiController]
[GameRoute("login")]
[Produces("text/plain")]
public class LoginController : ControllerBase
{
    [HttpPost]
    public IActionResult Login() => this.Ok("<authTicket>MM_AUTH=lh2</authTicket><lbpEnvVer>lighthouse2</lbpEnvVer><titleStorageURL></titleStorageURL>");
}