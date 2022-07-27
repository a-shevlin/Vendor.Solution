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
    public ActionResult Index(string name, string description)
    {
      MakeVendor make = new MakeVendor(name, description);
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
      return View(model);
    }

    [HttpPost("/vendor/{Id}")]
    public ActionResult Destroy(int id)
    {
      MakeVendor.RemoveVendor(id);
      return View();
    }

    [HttpPost("/vendor/{id}/orders")]
    public ActionResult New(int id, string title, string description, int price, string date)
    {
      Dictionary<string, object> model = new Dictionary<string, object> {};
      MakeVendor findVendor = MakeVendor.FindVendor(id);
      Order newOrder = new Order(title, description, price, date);
      findVendor.AddOrder(newOrder);
      List<Order> vendorOrder = findVendor.Orders;
      model.Add("orders", vendorOrder);
      model.Add("vendor", findVendor);
      return View("Show", model);
    }
  }
}