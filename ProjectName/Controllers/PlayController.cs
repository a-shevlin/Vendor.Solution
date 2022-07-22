using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;
using System;

namespace ProjectName.Controllers
{
  public class PlayController : Controller
  {
    [HttpGet("/play")]
    public ActionResult Index()
    {
      return View();
    }
    }
    {
  }
}