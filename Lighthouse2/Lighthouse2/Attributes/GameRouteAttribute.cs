﻿using Microsoft.AspNetCore.Mvc;

namespace Lighthouse2.Attributes;

public class GameRouteAttribute : RouteAttribute
{
    public GameRouteAttribute() : base($"LITTLEBIGPLANETPS3_XML/") {}
    public GameRouteAttribute(string route) : base($"LITTLEBIGPLANETPS3_XML/{route}") {}
}