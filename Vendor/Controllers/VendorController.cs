using Microsoft.AspNetCore.Mvc;
using Vendor.Models;
using System.Collections.Generic;
using System;

namespace Vendor.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendor")]
    public ActionResult Index()
    {
      List<MakeVendor> allVendors = MakeVendor.GetList();
      return View(allVendors);
    }

    [HttpGet("/vendor/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendor")]
    public ActionResult Index(string name, string desc)
    {
      MakeVendor make = new MakeVendor(name, desc);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendor/{Id}")]
    public ActionResult Show(int Id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      MakeVendor findVendor = MakeVendor.FindVendor(Id);
      List<Order> vendorOrders = findVendor.Orders;
      model.Add("vendor", findVendor);
      model.Add("orders", vendorOrders);
      Console.WriteLine();
      return View(model);
    }
  }
}