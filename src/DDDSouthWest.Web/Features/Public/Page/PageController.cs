﻿using Microsoft.AspNetCore.Mvc;

namespace DDDSouthWest.Web.Features.Public.Page
{
    public class PageController : Controller
    {
        public IActionResult Index(string filename)
        {
            return View($"~/Features/Public/Page/{filename}.cshtml");
        }
    }
}