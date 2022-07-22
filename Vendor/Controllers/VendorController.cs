using Microsoft.AspNetCore.Mvc;
using Vendor.Models;
using System;

namespace Vendor.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/play")]
    public ActionResult Index()
    {
      return View();
    }
  }
}