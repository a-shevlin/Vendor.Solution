using Microsoft.AspNetCore.Mvc;
using Vendor.Models;
using System.Collections.Generic;
using System;

namespace Vendor.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendor/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      MakeVendor vendor = MakeVendor.FindVendor(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendor/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.FindOrder(orderId);
      MakeVendor vendor = MakeVendor.FindVendor(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object> {};
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }
  }
}