using LBPUnion.Lighthouse2.Attributes;
using LBPUnion.Lighthouse2.Types;
using Microsoft.AspNetCore.Mvc;

namespace LBPUnion.Lighthouse2.Controllers;

[GameRoute("login")]
public class LoginController : GameController
{
    [HttpPost]
    public IActionResult Login() => this.Ok("<authTicket>MM_AUTH=lh2</authTicket><lbpEnvVer>lighthouse2</lbpEnvVer><titleStorageURL></titleStorageURL>");
}