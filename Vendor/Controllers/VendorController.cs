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
      return View(model);
    }

    [HttpPost("/vendor/{Id}")]
    public ActionResult Destroy(int id)
    {
      MakeVendor.RemoveVendor(id);
      return View();
    }

    [HttpPost("/vendor/{vendorId}/order")]
    public ActionResult New(int vendorId, string orderTitle, string orderDescription, int orderPrice, string orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object> {};
      MakeVendor foundVendor = MakeVendor.FindVendor(vendorId);
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrder = foundVendor.Orders;
      model.Add("orders", vendorOrder);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }
  }
}