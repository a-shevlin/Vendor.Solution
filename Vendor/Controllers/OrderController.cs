using Microsoft.AspNetCore.Mvc;
using Vendor.Models;
using System;

namespace Vendor.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendor/{vendorId}/order/new")]
    public ActionResult New(int vendorId)
    {
      MakeVendor vendor = MakeVendor.FindVendor(vendorId);
      return View(vendor);
    }
  }
}