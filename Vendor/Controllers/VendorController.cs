using Microsoft.AspNetCore.Mvc;
using Vendor.Models;
using System.Collections.Generic;
using System;

namespace Vendor.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendor/")]
    public ActionResult Index()
    {
      List<MakeVendor> allVendors = MakeVendor.GetList();
      return View();
    }
  }
}