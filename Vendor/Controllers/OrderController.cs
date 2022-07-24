using Microsoft.AspNetCore.Mvc;
using Vendor.Models;
using System.Collections.Generic;
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

    [HttpGet("/vendor/{vendorId}/order/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.FindOrder(orderId);
      MakeVendor vendor = MakeVendor.FindVendor(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object> {};
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }

    [HttpPost("/vendor/{vendorId}order/{orderId}")]
    public ActionResult Create(string title, string description, int price, string date)
    {
      Order newOrder = new Order(title, description, price, date);
      return RedirectToAction("Show");
    }
  }
}