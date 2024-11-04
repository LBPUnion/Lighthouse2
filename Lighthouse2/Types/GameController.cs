using LBPUnion.Lighthouse2.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace LBPUnion.Lighthouse2.Types;

[ApiController]
[GameRoute]
[Produces("text/plain")] // this should be replaced with "text/xml" when the formatter for that exists
public class GameController : ControllerBase;